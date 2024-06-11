using System;
using System.Windows.Forms;

namespace Knihovna
{
    public partial class UserForm : Form
    {
        private int userId;
        private DatabaseService databaseService;
        private Book book;
        private User user;

        public UserForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.databaseService = new DatabaseService();
            book = new Book();
            user = new User();
            LoadBooks();
            LoadLoans();
        }

        private void btnLoanBook_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem != null)
            {
                Book selectedBook = (Book)lstBooks.SelectedItem;
                book.BorrowBook(selectedBook.Id, userId);
                LoadBooks();
                LoadLoans();
                MessageBox.Show($"Kniha \"{selectedBook.Title}\" byla vypůjčena");
            }
            else
            {
                MessageBox.Show("Kniha nebyla vybrána");
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (lstLoans.SelectedItem != null)
            {
                Book selectedBook = (Book)lstLoans.SelectedItem;
                book.ReturnBook(selectedBook.Id, userId);
                LoadBooks();
                LoadLoans();
                MessageBox.Show($"Kniha \"{selectedBook.Title}\" byla úspěšně vrácena");
            }
            else
            {
                MessageBox.Show("Kniha nebyla vybrána");
            }
        }

        private void LoadBooks()
        {
            lstBooks.Items.Clear();
            var books = book.GetAllBooks();
            foreach (var book in books)
            {
                if (!book.Borrowed)
                {
                    lstBooks.Items.Add(book);
                }
            }
        }

        private void LoadLoans()
        {
            lstLoans.Items.Clear();
            var loans = user.GetLoansForUser(userId); 
            foreach (var book in loans)
            {                
                lstLoans.Items.Add(book + " Vypůjčeno dne: " + book.LoanDate.ToShortDateString());
            }
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       

        private void zpetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
       
        private void zmenitHeslo_click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(userId);
            changePasswordForm.ShowDialog();
        }

        private void zmenitHesloClick(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(userId);
            changePasswordForm.ShowDialog();            
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm("user");
            helpForm.ShowDialog();
        }
    }
}
