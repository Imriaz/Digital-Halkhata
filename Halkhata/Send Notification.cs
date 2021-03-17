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
using System.Net;
using System.IO;
using System.Net.Http;

namespace Halkhata
{
    public partial class Send_Notification : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = 127.0.0.1;port=3306; database=halkhatadb; username=root;password=;");
        MySqlCommand command;
        MySqlDataReader mdr;
        public Send_Notification()
        {
            InitializeComponent();
        }

        private void transactionDatashow()
        {
            string search = "SELECT Customer_Name, Customer_Phone_Number, SUM(Purchase_Amount) AS Total_Purchase, SUM(Payment) AS Total_Payment, SUM((Purchase_Amount - Payment)) AS Due_Amount FROM transaction GROUP BY Customer_Phone_Number; ";

            command = new MySqlCommand(search, connection);
            connection.Open();
            mdr = command.ExecuteReader();

            while (mdr.Read())
            {

                ListViewItem lvi = new ListViewItem(mdr.GetString(0));
                lvi.SubItems.Add(mdr.GetString(1));
                lvi.SubItems.Add(mdr.GetInt32(2).ToString());
                lvi.SubItems.Add(mdr.GetInt32(3).ToString());
                lvi.SubItems.Add(mdr.GetInt32(4).ToString());

                listView_sendnotification.Items.Add(lvi);

            }
            connection.Close();
        }

        private void Send_Notification_Load(object sender, EventArgs e)
        {
            listView_sendnotification.GridLines = true;
            listView_sendnotification.View = View.Details;

            listView_sendnotification.Columns.Add("Customer Name", 150);
            listView_sendnotification.Columns.Add("Customer Phone Number", 150);
            listView_sendnotification.Columns.Add("Purchase Amount", 150);
            listView_sendnotification.Columns.Add("Payment", 150);
            listView_sendnotification.Columns.Add("Due Amount", 150);

            transactionDatashow();
        }

        private void listView_sendnotification_MouseClick(object sender, MouseEventArgs e)
        {
            phone_no_textBox.Text = listView_sendnotification.SelectedItems[0].SubItems[1].Text;
        }

        private void backtomenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu access = new AdminMenu();
            access.Show();
        }

        private static readonly HttpClient client = new HttpClient();

        private async void send_message_button_Click(object sender, EventArgs e)
        {
            string phone = phone_no_textBox.Text;
            string msg = write_message_tBox.Text;

            IDictionary<string, string> values = new Dictionary<string, string>();
            values.Add(new KeyValuePair<string, string>("token", "fb6c2a743d287ade2016e918508c99c6"));
            values.Add(new KeyValuePair<string, string>("to", phone)); ;
            values.Add(new KeyValuePair<string, string>("message", msg));

            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("http://api.greenweb.com.bd/api.php?", content);

            var responseString = await response.Content.ReadAsStringAsync();
        }

    }
}


