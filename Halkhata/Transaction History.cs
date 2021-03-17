using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Halkhata
{
    public partial class Transaction_History : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = 127.0.0.1; port=3306; database=halkhatadb; username=root; password=;");
        MySqlCommand command;
        MySqlDataReader mdr;

        public Transaction_History()
        {
            InitializeComponent();
        }


        private void Transaction_History_Load(object sender, EventArgs e)
        {
            search_transaction_TextBox.Text = Program.searchText;
            Program.searchText = "";

            transaction_listView.GridLines = true;
            transaction_listView.View = View.Details;

            transaction_listView.Columns.Add("Transaction ID", 150);
            transaction_listView.Columns.Add("Name", 150);
            transaction_listView.Columns.Add("Phone Number", 150);
            transaction_listView.Columns.Add("Purchase Amount", 150);
            transaction_listView.Columns.Add("Payment", 150);
            transaction_listView.Columns.Add("Date & Time", 150);
        }

        

        private void search_transaction_button_Click(object sender, EventArgs e)
        {
            transaction_listView.Items.Clear();

            MySqlCommand purchase = new MySqlCommand("SELECT SUM(Purchase_Amount) AS P_amount FROM transaction WHERE Customer_Phone_Number = '" + this.search_transaction_TextBox.Text + "'", connection);
            MySqlDataReader reader;
            connection.Open();
            reader = purchase.ExecuteReader();
            while (reader.Read())
            {
                t_purchase_amounttextBox.Text = reader["P_amount"].ToString();
            }
            connection.Close();

            MySqlCommand payment = new MySqlCommand("SELECT SUM(Payment) AS Pay FROM transaction WHERE Customer_Phone_Number = '" + this.search_transaction_TextBox.Text + "'", connection);
            MySqlDataReader reader1;
            connection.Open();
            reader1 = payment.ExecuteReader();
            while (reader1.Read())
            {
                t_paymenttextBox.Text = reader1["Pay"].ToString();
            }
            connection.Close();

            if (t_purchase_amounttextBox.Text == "")
            {
                t_purchase_amounttextBox.Text = "0";
            }
            if (t_paymenttextBox.Text == "")
            {
                t_paymenttextBox.Text = "0";
            }

            t_due_textBox.Text = (Convert.ToInt32(t_purchase_amounttextBox.Text) - Convert.ToInt32(t_paymenttextBox.Text)).ToString();

            string search = "SELECT * FROM transaction WHERE Customer_Phone_Number = '" + this.search_transaction_TextBox.Text + "';";

            command = new MySqlCommand(search, connection);
            connection.Open();
            mdr = command.ExecuteReader();
            
            while (mdr.Read())
            {
                
                ListViewItem lvi = new ListViewItem(mdr.GetInt32(0).ToString());
                lvi.SubItems.Add(mdr.GetString(1));
                lvi.SubItems.Add(mdr.GetInt32(2).ToString());
                lvi.SubItems.Add(mdr.GetString(3));
                lvi.SubItems.Add(mdr.GetString(4));
                lvi.SubItems.Add(mdr.GetString(5));

                transaction_listView.Items.Add(lvi);

            }

            connection.Close();
        }

        private void gobackpage_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Profile access = new Customer_Profile();
            access.Show();
        }


    }
}
