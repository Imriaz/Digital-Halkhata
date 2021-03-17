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
    public partial class TransactionStatement : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = 127.0.0.1;port=3306; database=halkhatadb; username=root;password=;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        MySqlDataReader mdr;

        public TransactionStatement()
        {
            InitializeComponent();
        }

        private void record_statement_button_Click(object sender, EventArgs e)
        {
            int phoneNumber = Convert.ToInt32(t_customer_phone_number_textBox.Text);

            connection.Open();

            string selectQuery = "SELECT * FROM customer WHERE Phone_Number = '" + phoneNumber + "';";

            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                MessageBox.Show("Username not available!");

            }
            else
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=halkhatadb;";
                string iquery = "INSERT INTO transaction(Transaction_ID, Customer_Name, Customer_Phone_Number, Purchase_Amount, Payment, Date_Time) VALUES ('" + textBoxTransactionID.Text + "', '" + t_customer_NametextBox.Text + "', '" + t_customer_phone_number_textBox.Text + "', '" + purchasetextBox.Text + "', '" + paymenttextBox.Text + "', '" + DateTime.Now.ToString("yyyy-MM-dd h:mm tt") + "')";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(iquery, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Record Successfully Saved!");
            }

            connection.Close();

        }

        private void gobackmenu_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu access = new AdminMenu();
            access.Show();
        }

        private void TransactionStatement_Load(object sender, EventArgs e)
        {
            t_phoneserach_textBox.Text = Program.searchText;
            Program.searchText = "";

            String query = "SELECT CONCAT(First_Name,' ', Last_Name) AS Name, Phone_Number AS PhoneNo FROM customer;";

            DataTable table = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            customerdetailsdataGridView.DataSource = table;
            Transaction_Id();
        }

        public void Transaction_Id()
        {
            connection.Open();

            string query1 = "select max(Transaction_ID) from transaction";
            MySqlCommand cmd1 = new MySqlCommand(query1, connection);
            MySqlDataReader dr1;
            dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                string value = dr1[0].ToString();
                if (value == "")
                {
                    textBoxTransactionID.Text = "6538427";
                }
                else
                {
                    int b;
                    b = int.Parse(dr1[0].ToString());
                    b +=  1;
                    textBoxTransactionID.Text = b.ToString();

                }
                connection.Close();
            }
        }
        private void customerdetailsdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.customerdetailsdataGridView.Rows[e.RowIndex];
                t_customer_NametextBox.Text = row.Cells["Name"].Value.ToString();
                t_customer_phone_number_textBox.Text = row.Cells["PhoneNo"].Value.ToString();
            }
        }

        private void t_search_button_Click(object sender, EventArgs e)
        {
            string search = "SELECT CONCAT(First_Name,' ', Last_Name) AS Name, Phone_Number AS PhoneNo FROM customer WHERE Phone_Number = '" + this.t_phoneserach_textBox.Text + "';";
            command = new MySqlCommand(search, connection);
            connection.Open();
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                t_customer_NametextBox.Text = mdr.GetString("Name");
                t_customer_phone_number_textBox.Text = mdr.GetString("PhoneNo");

            }
            else
            {
                MessageBox.Show("Customer Not Found");
            }

            connection.Close();
        }
    }
}
