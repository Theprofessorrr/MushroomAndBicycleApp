using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ByNMushroomApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.",
                                "Login Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                

            }
            else
            {
                MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Open Choose Form and hide Login Form
            ChooseForm chooseForm = new ChooseForm();
            chooseForm.Show();
            this.Hide();
            }
        }
    }
}
