using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeaMart
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            if (tbx_username.Text == "admin" && tbx_password.Text == "admin")
            {
                new Form1().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Username or Password is wrong");
                tbx_username.Clear();
                tbx_password.Clear();
                tbx_username.Focus();
            }
        }
    }
}
