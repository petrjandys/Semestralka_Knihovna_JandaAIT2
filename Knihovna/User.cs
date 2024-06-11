using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;

namespace Knihovna
{
    public class User
    {
        private static string connectionString = "Data Source=library.db;Version=3;";

        public int Id { get; set; }
        public string Username { get; set; }
        public bool IsAdmin { get; set; }       

        public void AddUser(string username, string password, bool isAdmin)
        {
            string hashedPassword = HashPassword(password);

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Users (Username, Password, IsAdmin) VALUES (@Username, @Password, @IsAdmin)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", hashedPassword);
                    command.Parameters.AddWithValue("@IsAdmin", isAdmin);
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool ValidateUser(string username, string password, out bool isAdmin, out int userId)
        {
            string hashedPassword = HashPassword(password);

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", hashedPassword);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isAdmin = reader.GetBoolean(reader.GetOrdinal("IsAdmin"));
                            userId = reader.GetInt32(reader.GetOrdinal("Id"));
                            return true;
                        }
                        else
                        {
                            isAdmin = false;
                            userId = -1;
                            return false;
                        }
                    }
                }
            }
        }

        public string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte t in bytes)
                {
                    builder.Append(t.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public void ChangePassword(int userId, string newPassword)
        {
            string hashedPassword = HashPassword(newPassword);

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Users SET Password = @Password WHERE Id = @UserId";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Password", hashedPassword);
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteUser(int userId)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Users WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", userId);
                    command.ExecuteNonQuery();
                }
            }
        }
        public string GetUserNameById(int userId)
        {
            string username = "";
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Username FROM Users WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", userId);
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        username = result.ToString();
                    }
                }
            }
            return username;
        }
        public List<Book> GetLoansForUser(int userId)
        {
            List<Book> loans = new List<Book>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Books WHERE Borrowed = 1 AND Id IN (SELECT BookId FROM Loans WHERE UserId = @UserId AND ReturnDate IS NULL)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            loans.Add(new Book
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
            return loans;
        }
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Users";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Username = reader.GetString(reader.GetOrdinal("Username")),
                                IsAdmin = reader.GetBoolean(reader.GetOrdinal("IsAdmin"))
                            });
                        }
                    }
                }
            }
            return users;
        }
        
    }
}
