using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knihovna
{
    public partial class WelcomeForm : Form
    {
        private DatabaseService databaseService;
        public WelcomeForm()
        {
            InitializeComponent();
            databaseService = new DatabaseService();
        }

        private void btnLoginForm_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
        private void btnAbout_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm("about");
            helpForm.ShowDialog();
        }
    }
}
