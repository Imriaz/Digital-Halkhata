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
    public partial class Customer_Profile : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = 127.0.0.1; port=3306; database=halkhatadb; username=root; password=;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        MySqlDataReader mdr;

        public Customer_Profile()
        {
            InitializeComponent();
        }

        public void ShowCustomerData()
        {
            String query = "SELECT First_Name, Last_Name, Email, Address, Phone_Number, Gender FROM customer";

            DataTable table = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dataGridViewcustomer.DataSource = table;
        }

        private void Customer_Profile_Load(object sender, EventArgs e)
        {
            ShowCustomerData();
        }

        private void dataGridViewcustomer_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewcustomer.Rows[e.RowIndex];
                c_email_textBox.Text = row.Cells["Email"].Value.ToString();
                c_firstnametextBox.Text = row.Cells["First_Name"].Value.ToString();
                c_lastnametextBox.Text = row.Cells["Last_Name"].Value.ToString();
                c_addresstextBox.Text = row.Cells["Address"].Value.ToString();
                c_contactnumtextBox.Text = row.Cells["Phone_Number"].Value.ToString();
            }
        }

        private void find_button_Click(object sender, EventArgs e)
        {
            string search = "SELECT * FROM customer WHERE Phone_Number = '" + this.searchTextBox.Text + "';";
            command = new MySqlCommand(search, connection);
            connection.Open();
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                c_email_textBox.Text = mdr.GetString("Email");
                c_firstnametextBox.Text = mdr.GetString("First_Name");
                c_lastnametextBox.Text = mdr.GetString("Last_Name");
                c_addresstextBox.Text = mdr.GetString("Address");
                c_contactnumtextBox.Text = mdr.GetString("Phone_Number");

            }
            else
            {
                MessageBox.Show("Customer Not Found!");
            }

            connection.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu access = new AdminMenu();
            access.Show();
        }

        private void finish_update_button_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "datasource=127.0.0.1; port=3306; username=root; password=; database=halkhatadb;";

                string Query = "UPDATE customer SET Email = '" + this.c_email_textBox.Text + "', First_Name = '" + this.c_firstnametextBox.Text + "', Last_Name = '" + this.c_lastnametextBox.Text + "', Address = '" + this.c_addresstextBox.Text + "', Phone_Number = '" + this.c_contactnumtextBox.Text + "' where Phone_Number = '" + this.searchTextBox.Text + "';";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(Query, databaseConnection);
                MySqlDataReader myReader;

                databaseConnection.Open();
                myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Data Updated Successfully!");

                while (myReader.Read())
                {
                }
                databaseConnection.Close();
                ShowCustomerData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "datasource=127.0.0.1; port=3306; username=root; password=; database=halkhatadb;";

                string Query = "delete from halkhatadb.customer where Phone_Number='" + this.searchTextBox.Text + "';";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(Query, databaseConnection);
                MySqlDataReader myReader;

                databaseConnection.Open();
                myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Account has been successfully Deleted!");
                while (myReader.Read())
                {
                }
                databaseConnection.Close();
                ShowCustomerData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void transaction_history_button_Click(object sender, EventArgs e)
        {
            Program.searchText = searchTextBox.Text;
            this.Hide();
            Transaction_History access = new Transaction_History();
            access.Show();
            
        }

        private void trasaction_board_button_Click(object sender, EventArgs e)
        {
            Program.searchText = searchTextBox.Text;
            this.Hide();
            this.Hide();
            TransactionStatement access = new TransactionStatement();
            access.Show();
        }
    }
}


