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
    public partial class Transaction_Data : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = 127.0.0.1; port=3306; database=halkhatadb; username=root; password=;");
        MySqlCommand command;
        MySqlDataReader mdr;

        public Transaction_Data()
        {
            InitializeComponent();
        }

        private void Transaction_Data_Load(object sender, EventArgs e)
        {
            transaction_data_listView.GridLines = true;
            transaction_data_listView.View = View.Details;

            transaction_data_listView.Columns.Add("Customer Name", 150);
            transaction_data_listView.Columns.Add("Customer Phone Number", 150);
            transaction_data_listView.Columns.Add("Purchase Amount", 150);
            transaction_data_listView.Columns.Add("Payment", 150);
            transaction_data_listView.Columns.Add("Date & Time", 150);

            transactionDatashow();
        }

        private void transactionDatashow()
        {
            string search = "SELECT Customer_Name, Customer_Phone_Number, Purchase_Amount, Payment, Date_Time FROM transaction;";

            command = new MySqlCommand(search, connection);
            connection.Open();
            mdr = command.ExecuteReader();

            while (mdr.Read())
            {

                ListViewItem lvi = new ListViewItem(mdr.GetString(0));
                lvi.SubItems.Add(mdr.GetString(1));
                lvi.SubItems.Add(mdr.GetString(2));
                lvi.SubItems.Add(mdr.GetString(3));
                lvi.SubItems.Add(mdr.GetString(4));

                transaction_data_listView.Items.Add(lvi);

            }
            connection.Close();
        }

        private void gobackmenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu access = new AdminMenu();
            access.Show();
        }

        private void Load_button_Click(object sender, EventArgs e)
        {
            transaction_data_listView.Items.Clear();

            DateTime fromDate1 = from_dateTimePicker.Value.Date;
            DateTime toDate1 = to_dateTimePicker.Value.Date;

            string fromDate = fromDate1.ToString("yyyy-MM-dd");
            string toDate = toDate1.ToString("yyyy-MM-dd");

            string search = "SELECT Customer_Name, Customer_Phone_Number, Purchase_Amount, Payment, Date_Time FROM transaction WHERE DATE(Date_Time) BETWEEN '" + fromDate + "' AND '" + toDate + "'";

            command = new MySqlCommand(search, connection);
            connection.Open();
            mdr = command.ExecuteReader();

            while (mdr.Read())
            {

                ListViewItem lvi = new ListViewItem(mdr.GetString(0));
                lvi.SubItems.Add(mdr.GetInt32(1).ToString());
                lvi.SubItems.Add(mdr.GetString(2));
                lvi.SubItems.Add(mdr.GetString(3));
                lvi.SubItems.Add(mdr.GetString(4));

                transaction_data_listView.Items.Add(lvi);
            }
            connection.Close();
        }
    }
}
