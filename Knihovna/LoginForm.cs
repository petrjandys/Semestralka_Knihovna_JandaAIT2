﻿using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Knihovna
{
    public partial class LoginForm : Form
    {
        private User user;
        private DatabaseService databaseService;

        public LoginForm()
        {
            InitializeComponent();
            databaseService = new DatabaseService();
            user = new User();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                PerformLogin();
            }
        }

        private void PerformLogin()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (user.ValidateUser(username, password, out bool isAdmin, out int userId))
            {
                if (isAdmin && user.HashPassword(password) == databaseService.defaultPass)
                {
                    MessageBox.Show("Prosím, změnte heslo pro admina", "Bezpečnost", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ChangePasswordForm changePasswordForm = new ChangePasswordForm(userId);
                    changePasswordForm.ShowDialog();
                }

                if (isAdmin)
                {
                    MainForm mainForm = new MainForm(isAdmin);
                    mainForm.Show();
                }
                else
                {
                    UserForm userForm = new UserForm(userId);
                    userForm.Show();
                }

                this.Hide();
            }
            else
            {
                txtPassword.SelectionStart = 0;
                txtPassword.SelectionLength = txtPassword.Text.Length;
                chybaPrihlaseniLabel.Visible = true;           
                
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
