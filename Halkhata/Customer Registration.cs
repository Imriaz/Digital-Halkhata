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
    public partial class Customer_Registration : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = 127.0.0.1; port=3306; database=halkhatadb; username=root;password=;");
        MySqlCommand command;
        MySqlDataReader mdr;

        public Customer_Registration()
        {
            InitializeComponent();
        }

        string Gender;

        private void finish_button_Click(object sender, EventArgs e)
        {
            connection.Open();
            string selectQuery = "SELECT * FROM halkhatadb.customer WHERE Phone_Number = '" + this.c_contactnumtextBox.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                MessageBox.Show("Account Already Exists!");

            }
            else
            {
                string connectionString = "datasource=127.0.0.1; port=3306; username=root; password=; database=halkhatadb;";
                string iquery = "INSERT INTO customer(Halkhata_ID, First_Name, Last_Name, Email, Address, Phone_Number, Gender) VALUES ('" + this.halkhataid_textBox.Text + "', '" + this.c_firstnametextBox.Text + "', '" + this.c_lastnametextBox.Text + "', '" + this.c_emailtextBox.Text + "', '" + this.c_addresstextBox.Text + "', '" + this.c_contactnumtextBox.Text + "', '" + this.Gender + "')";

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

                MessageBox.Show("Account Successfully Created!");
            }

            connection.Close();

        }

        private void male_Button_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void female_Button_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu access = new AdminMenu();
            access.Show();
        }

        public void Halkhata_Id()
        {
            connection.Open();

            string iquery = "select max(Halkhata_ID) from customer";
            MySqlCommand acmd = new MySqlCommand(iquery, connection);
            MySqlDataReader reader1;
            reader1 = acmd.ExecuteReader();
            if (reader1.Read())
            {
                string value = reader1[0].ToString();
                if (value == "")
                {
                    halkhataid_textBox.Text = "201901";
                }
                else
                {
                    int b;
                    b = int.Parse(reader1[0].ToString());
                    b += 1;
                    halkhataid_textBox.Text = b.ToString();

                }
                connection.Close();

            }
        }

        private void Customer_Registration_Load(object sender, EventArgs e)
        {
            Halkhata_Id();
        }

        private void gotodashboard_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Profile access = new Customer_Profile();
            access.Show();
        }
    }
}
