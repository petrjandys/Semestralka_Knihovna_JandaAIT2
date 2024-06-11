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
    public partial class UserBorrowedBooksForm : Form
    {
        public UserBorrowedBooksForm(List<Book> borrowedBooks, string username)
        {
            InitializeComponent();
            lblUsername.Text = $"Knihy vypůjčené uživatelem: {username}";
            lstBorrowedBooks.Items.Clear();
            foreach (var book in borrowedBooks)
            {
                string bookInfo = $"{book} Vypůjčeno dne: { book.LoanDate.ToShortDateString()}";
                lstBorrowedBooks.Items.Add(bookInfo);
                
            }
        }
    }
}