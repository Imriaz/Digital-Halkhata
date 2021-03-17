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
    public partial class AdminLogin : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = 127.0.0.1;port=3306; database=halkhatadb; username=root;password=;");
        MySqlCommand command;
        MySqlDataReader mdr;

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void adminRegister_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_registration createAdmin = new admin_registration();
            createAdmin.Show();
        }

        private void adminLogin_button_Click(object sender, EventArgs e)
        {
            connection.Open();

            string selectQuery = "SELECT * FROM halkhatadb.admin WHERE Admin_Email = '" + admin_emailtextBox.Text + "' AND Admin_Password = '" + admin_passwordtextBox.Text + "';";

            command = new MySqlCommand(selectQuery, connection);

            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                MessageBox.Show("Login Successful!");
                this.Hide();
                AdminMenu access = new AdminMenu();
                access.Show();


            }
            else
            {
                MessageBox.Show("Incorrect Login Information! Try again.");
            }

            connection.Close();

            if (string.IsNullOrEmpty(admin_emailtextBox.Text) || string.IsNullOrEmpty(admin_passwordtextBox.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            admin_passwordtextBox.PasswordChar = '*';
        }

        private void show_pwd_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(show_pwd_checkBox.Checked)
            {
                admin_passwordtextBox.UseSystemPasswordChar = true;
            }
            else
            {
                admin_passwordtextBox.UseSystemPasswordChar = false;
            }
        }


    }
}
