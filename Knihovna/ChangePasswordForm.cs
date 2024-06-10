using System;
using System.Windows.Forms;

namespace Knihovna
{
    public partial class ChangePasswordForm : Form
    {
        private int userId;
        private User user;

        public ChangePasswordForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.user = new User();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Zadejte nové heslo a potvrzení hesla.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Hesla se neshodují.");
                return;
            }

            user.ChangePassword(userId, newPassword);
            MessageBox.Show("Heslo bylo úspěšně změněno.");
            this.Close();
        }
    }
}
