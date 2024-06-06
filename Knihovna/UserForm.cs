﻿using System;
using System.Windows.Forms;

namespace Knihovna
{
    public partial class UserForm : Form
    {
        private int userId;
        private DatabaseService databaseService;
        private Book book;

        public UserForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.databaseService = new DatabaseService();
            book = new Book();
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
            var loans = book.GetAllBooks();
            foreach (var book in loans)
            {
                if (book.Borrowed)
                {
                    lstLoans.Items.Add(book);
                }
            }
        }
    }
}