using System;
using System.Data.SqlClient;

namespace AdoNetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Server=.\\SQLEXPRESS;Database=CSharpb8;User Id=csharpb8;Password=123456;";

            var insertSql = "Select * FROM Students";
            var DeleteSql = "Delete from students where name = 'mukit'";

            ExecuteNonQuery(connectionString, DeleteSql);
        }


        public static void ExecuteNonQuery(string connectionString, string query)
        {
            DBConnection connection = new DBConnection(connectionString);

            var command = connection.GetCommand();

            command.CommandText = query;
            command.ExecuteNonQuery();

            connection.Destroy();
        }

        public static void ExecuteQuery(string connectionString, string query)
        {
            DBConnection connection = new DBConnection(connectionString);

            var command = connection.GetCommand();
            command.CommandText = query;

        }
    }
}
