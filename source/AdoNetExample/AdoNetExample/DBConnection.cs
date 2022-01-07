using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdoNetExample
{
    public class DBConnection
    {
        private static string ConnectionString {get; set;}

        public DBConnection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        private SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConnectionString;

            //check if db connection is open?
            //if not then open
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            return connection;
        }

        public SqlCommand GetCommand()
        {
            //create sql commad
            SqlCommand command = new SqlCommand();
            command.Connection = GetConnection();

            return command;
        }


        public void Destroy()
        {
            //distroy the commad imidiatly
            GetCommand().Dispose();

            if (GetConnection().State == System.Data.ConnectionState.Open)
            {
                GetConnection().Close();
            }

            //distry the connection
            GetConnection().Dispose();
        }
    }
}
