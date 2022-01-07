using System.Data.SqlClient;

namespace AdoNet.Console
{
    public class DBConnection
    {
        private readonly string _dbConnectionString;
        public DBConnection(string dbConnectionString)
        {
            _dbConnectionString = dbConnectionString;
        }

        protected SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(_dbConnectionString);

            if(connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            return connection;
        }

        protected SqlCommand GetCommand()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = GetConnection();

            return command;
        }

        public void Destroy()
        {
            if(GetConnection().State != System.Data.ConnectionState.Closed)
                GetConnection().Close();

            GetConnection().Dispose();
        }
    }
}
