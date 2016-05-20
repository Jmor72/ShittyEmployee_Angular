using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace ShittyEmployee_Angular
{
    public class DatabaseInit
    {
        public SQLiteConnection sqlite_conn;
        public SQLiteCommand sqlite_cmd;
        public SQLiteDataReader sqlite_datareader;

        public void Database()
        {
            var sql_path = @"C:\dev\ShittyEmployee_SQLite\src\ShittyEmployee_SQLite\EmployeeDB.sqlite3";
            sqlite_conn = new SQLiteConnection($"Data Source={sql_path};version=3;");
            sqlite_conn.Open();
            //sqlite_cmd = sqlite_conn.CreateCommand();
            //SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=EmployeeDB.sqlite3;version=3.8.8.3;");
        }
    }
}
