using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ont_design
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            passwordTextBox.UseSystemPasswordChar = true;
        }

        private void linkLabelToQuitApp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }


        private void Username_TextChanged(object sender, EventArgs e)
        {


        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {

                return;
            }

            if (username == "shopadmin" && password == "letmein")
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else if (username == "wholesale-admin" && password == "letmein")
            {
                WholesaleDash dash = new WholesaleDash();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }

        }

        private void showPasswordRadio_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void viewPasswordBox_CheckedChanged(object sender, EventArgs e)
        {
            if (viewPasswordBox.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void forgotPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm forgotpassword = new ForgotPasswordForm();
            forgotpassword.Show();

        }
    }

}
