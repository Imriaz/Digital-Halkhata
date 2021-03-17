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
    public partial class admin_registration : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = 127.0.0.1;port=3306; database=halkhatadb; username=root;password=;");
        MySqlCommand command;
        MySqlDataReader mdr;

        public admin_registration()
        {
            InitializeComponent();
        }

        private void Finish_button_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            string selectQuery = "SELECT * FROM halkhatadb.admin WHERE Admin_Phone_Number = '" + this.admin_phone_textBox.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                MessageBox.Show("Admin Account Already Exists!");

            }
            else
            {
                string connectionString = "datasource=127.0.0.1; port=3306; username=root; password=; database=halkhatadb;";
                string iquery = "INSERT INTO admin(Admin_ID, Admin_First_Name, Admin_Last_Name, Admin_Email, Admin_Password, Admin_Phone_Number) VALUES ('" + this.admin_idtextBox.Text +"', '" + this.a_firstnametextBox.Text + "', '" + this.a_lastnametextBox.Text + "', '" + this.a_emailtextBox.Text + "', '" + this.a_passwordtextBox.Text + "', '" + this.admin_phone_textBox.Text + "')";

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
                    // Show any error message.
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Account Successfully Created!");
            }

            connection.Close();

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin access = new AdminLogin();
            access.Show();
        }

        public void Admin_Id()
        {
            connection.Open();

            string iquery = "select max(Admin_ID) from admin";
            MySqlCommand acmd = new MySqlCommand(iquery, connection);
            MySqlDataReader reader1;
            reader1 = acmd.ExecuteReader();
            if (reader1.Read())
            {
                string value = reader1[0].ToString();
                if (value == "")
                {
                    admin_idtextBox.Text = "181921";
                }
                else
                {
                    int b;
                    b = int.Parse(reader1[0].ToString());
                    b += 1;
                    admin_idtextBox.Text = b.ToString();

                }
                connection.Close();
            }
        }

        private void admin_registration_Load(object sender, EventArgs e)
        {
            Admin_Id();
        }
    }
}
