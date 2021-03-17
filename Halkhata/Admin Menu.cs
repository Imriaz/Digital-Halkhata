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
    public partial class AdminMenu : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = 127.0.0.1; port=3306; database=halkhatadb; username=root; password=;");

        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            showsummarydata();
        }

        private void showsummarydata()
        {
            MySqlCommand purchase = new MySqlCommand("SELECT SUM(Purchase_Amount) AS P_amount FROM transaction", connection);
            MySqlDataReader reader;
            connection.Open();
            reader = purchase.ExecuteReader();
            while (reader.Read())
            {
                halkhata_purchase_textBox.Text = reader["P_amount"].ToString();
            }
            connection.Close();

            MySqlCommand payment = new MySqlCommand("SELECT SUM(Payment) AS Pay FROM transaction", connection);
            MySqlDataReader reader1;
            connection.Open();
            reader1 = payment.ExecuteReader();
            while (reader1.Read())
            {
                halakhata_balance_textBox.Text = reader1["Pay"].ToString();
            }
            connection.Close();

            if(halkhata_purchase_textBox.Text == "")
            {
                halkhata_purchase_textBox.Text = "0" ;
            }
            if(halakhata_balance_textBox.Text == "")
            {
                halakhata_balance_textBox.Text = "0";
            }

            halkhata_due_textBox.Text = (Convert.ToInt32(halkhata_purchase_textBox.Text) - Convert.ToInt32(halakhata_balance_textBox.Text)).ToString();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Registration access = new Customer_Registration();
            access.Show();
        }

        private void transaction_statement_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionStatement access = new TransactionStatement();
            access.Show();
        }

        private void Customer_DashBoardbutton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Profile access = new Customer_Profile();
            access.Show();
        }

        private void view_transaction_Data_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction_Data access = new Transaction_Data();
            access.Show();
        }

        private void Send_reminderbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Send_Notification access = new Send_Notification();
            access.Show();
        }

        private void logout_Button_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm access = new LoginForm();
            access.Show();
        }

 
    }
}
