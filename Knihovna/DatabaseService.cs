using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Knihovna
{
    public class DatabaseService
    {
        private string connectionString = "Data Source=library.db;Version=3;";
        public string defaultPass = "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918";

        public DatabaseService()
        {
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createUsersTable = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL,
                        Password TEXT NOT NULL,
                        IsAdmin INTEGER NOT NULL
                    )";

                string createBooksTable = @"
                    CREATE TABLE IF NOT EXISTS Books (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Title TEXT NOT NULL,
                        Author TEXT NOT NULL,
                        Year INTEGER NOT NULL,
                        Borrowed BOOLEAN NOT NULL DEFAULT 0
                    )";

                string createLoansTable = @"
                    CREATE TABLE IF NOT EXISTS Loans (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        BookId INTEGER NOT NULL,
                        UserId INTEGER NOT NULL,
                        LoanDate TEXT NOT NULL,
                        ReturnDate TEXT,
                        FOREIGN KEY(BookId) REFERENCES Books(Id),
                        FOREIGN KEY(UserId) REFERENCES Users(Id)
                    )";

                ExecuteNonQuery(createUsersTable, connection);
                ExecuteNonQuery(createBooksTable, connection);
                ExecuteNonQuery(createLoansTable, connection);

                string checkAdminUser = "SELECT COUNT(*) FROM Users WHERE Username = 'admin'";
                using (var command = new SQLiteCommand(checkAdminUser, connection))
                {
                    long count = (long)command.ExecuteScalar();
                    if (count == 0)
                    {
                        string insertAdminUser = @"
                            INSERT INTO Users (Username, Password, IsAdmin)
                            VALUES ('admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 1)";
                        ExecuteNonQuery(insertAdminUser, connection);
                        MessageBox.Show(@"Prvotní spuštění
Defaultní účet: admin/admin
");
                    }
                }
            }
        }

        private void ExecuteNonQuery(string query, SQLiteConnection connection)
        {
            using (var command = new SQLiteCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
