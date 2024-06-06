﻿using System;
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
            SetupUI();
        }

        private void SetupUI()
        {
            if (!isAdmin)
            {
                btnAddBook.Visible = false;
                btnDeleteBook.Visible = false;
                btnAddUser.Visible = false;
                btnDeleteUser.Visible = false;
            }
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
                string bookInfo = $"Kniha: {book.Title},    Autor: {book.Author},   Rok vydání: {book.Year}";
                lstBooks.Items.Add(bookInfo);
            }
        }

        private void LoadUsers()
        {
            lstUsers.Items.Clear();
            var users = user.GetAllUsers();
            foreach (var user in users)
            {
                string userInfo = $"Username: {user.Username}, je admin?: {user.IsAdmin}";
                lstUsers.Items.Add(userInfo);
            }
        }
    }
}