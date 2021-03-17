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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
  
        private void adminPanel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin login = new AdminLogin();
            login.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time_label.Text = DateTime.Now.ToString("h:mm tt");
            day_label.Text =  DateTime.Now.ToString("dddd");
            date_label.Text = DateTime.Now.ToString("MMM dd yyyy");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
