using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Knihovna
{
    public class Book
    {
        private static string connectionString = "Data Source=library.db;Version=3;";

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public bool Borrowed { get; set; }

        public override string ToString()
        {
            return $"Titul: {Title}     Autor: {Author}    Rok vydání: {Year}";
        }
        public void AddBook(string title, string author, int year)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Books (Title, Author, Year) VALUES (@Title, @Author, @Year)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Author", author);
                    command.Parameters.AddWithValue("@Year", year);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteBook(int bookId)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Books WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", bookId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Books";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new Book
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Title = reader.GetString(reader.GetOrdinal("Title")),
                                Author = reader.GetString(reader.GetOrdinal("Author")),
                                Year = reader.GetInt32(reader.GetOrdinal("Year")),
                                Borrowed = reader.GetBoolean(reader.GetOrdinal("Borrowed"))
                            });
                        }
                    }
                }
            }
            return books;
        }

        public void BorrowBook(int bookId, int userId)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string updateBookQuery = "UPDATE Books SET Borrowed = 1 WHERE Id = @BookId";
                using (var updateBookCommand = new SQLiteCommand(updateBookQuery, connection))
                {
                    updateBookCommand.Parameters.AddWithValue("@BookId", bookId);
                    updateBookCommand.ExecuteNonQuery();
                }

                string insertLoanQuery = "INSERT INTO Loans (BookId, UserId, LoanDate) VALUES (@BookId, @UserId, @LoanDate)";
                using (var insertLoanCommand = new SQLiteCommand(insertLoanQuery, connection))
                {
                    insertLoanCommand.Parameters.AddWithValue("@BookId", bookId);
                    insertLoanCommand.Parameters.AddWithValue("@UserId", userId);
                    insertLoanCommand.Parameters.AddWithValue("@LoanDate", DateTime.Now.ToString("yyyy-MM-dd"));
                    insertLoanCommand.ExecuteNonQuery();
                }
            }
        }

        public void ReturnBook(int bookId, int userId)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string updateBookQuery = "UPDATE Books SET Borrowed = 0 WHERE Id = @BookId";
                using (var updateBookCommand = new SQLiteCommand(updateBookQuery, connection))
                {
                    updateBookCommand.Parameters.AddWithValue("@BookId", bookId);
                    updateBookCommand.ExecuteNonQuery();
                }

                string updateLoanQuery = "UPDATE Loans SET ReturnDate = @ReturnDate WHERE BookId = @BookId AND UserId = @UserId AND ReturnDate IS NULL";
                using (var updateLoanCommand = new SQLiteCommand(updateLoanQuery, connection))
                {
                    updateLoanCommand.Parameters.AddWithValue("@ReturnDate", DateTime.Now.ToString("yyyy-MM-dd"));
                    updateLoanCommand.Parameters.AddWithValue("@BookId", bookId);
                    updateLoanCommand.Parameters.AddWithValue("@UserId", userId);
                    updateLoanCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
