using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostal_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "admin";
            string getUserName = login_txt.Text;
            string getPassword = pass_txt.Text;

            if (getUserName == username && getPassword == password)
            {
                MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Dashboard dForm = new Dashboard();
                dForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Usename / Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
