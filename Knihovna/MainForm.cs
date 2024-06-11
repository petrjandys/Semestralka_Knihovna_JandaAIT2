using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Knihovna
{
    public partial class MainForm : Form
    {
        private DatabaseService databaseService;
        private User user;
        private Book book;
        private bool isAdmin;

        public MainForm(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            databaseService = new DatabaseService(); 
            user = new User();
            book = new Book();
            LoadBooks();
            LoadUsers();            
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            int year = (int)numYear.Value;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
            {
                MessageBox.Show("Vyplň všechna pole");
                return;
            }

            book.AddBook(title, author, year);
            MessageBox.Show("Kniha úspěšně přidána");
            LoadBooks();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem == null)
            {
                MessageBox.Show("Označ knihu k vymazání");
                return;
            }            
            int selectedIndex = lstBooks.SelectedIndex;           
            Book selectedBook = book.GetAllBooks()[selectedIndex];           
            int bookId = selectedBook.Id;          
            book.DeleteBook(bookId);
            MessageBox.Show("Kniha vymazána z databáze");
            LoadBooks();
        }


        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool isAdmin = chkIsAdmin.Checked;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vyplň pole");
                return;
            }

            user.AddUser(username, password, isAdmin);
            MessageBox.Show("Uživatel přidán");
            LoadUsers();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (lstUsers.SelectedItem == null)
            {
                MessageBox.Show("Vyber uživatele");
                return;
            }       
            int selectedIndex = lstUsers.SelectedIndex;
            User selectedUser = user.GetAllUsers()[selectedIndex];
            int userId = selectedUser.Id;
            user.DeleteUser(userId);
            MessageBox.Show("Uživatel úspěšně vymazán");
            LoadUsers();
        }

        private void LoadBooks()
        {
            lstBooks.Items.Clear();
            var books = book.GetAllBooks();
            foreach (var book in books)
            {
                string bookInfo = book.ToString();
                lstBooks.Items.Add(bookInfo);
            }
        }

        private void LoadUsers()
        {
            lstUsers.Items.Clear();
            var users = user.GetAllUsers();
            foreach (var user in users)
            {
                string osloveni;
                if (user.IsAdmin)
                {
                    osloveni =  "administrator";
                }
                else { osloveni = "uživatel"; }

                string userInfo = $"{osloveni}  {user.Username}";
                lstUsers.Items.Add(userInfo);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void odhlasitSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
        private void ZmenitHesloClick(object sender, EventArgs e)
        { 
            User selectedUser = user.GetAllUsers()[lstUsers.SelectedIndex];
            int selectedUserId = selectedUser.Id;
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(selectedUserId);
            changePasswordForm.ShowDialog();
        }

        private void lstUserDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstUsers.SelectedItem == null)
            {
                return;
            }

            int selectedIndex = lstUsers.SelectedIndex;
            User selectedUser = user.GetAllUsers()[selectedIndex];
            List<Book> borrowedBooks = user.GetLoansForUser(selectedUser.Id);

            UserBorrowedBooksForm borrowedBooksForm = new UserBorrowedBooksForm(borrowedBooks, selectedUser.Username);
            borrowedBooksForm.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm("admin");
            helpForm.ShowDialog();
        }
    }
}
