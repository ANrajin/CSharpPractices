using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Console
{
    public class ExecuteQuery:DBConnection
    {
        public ExecuteQuery(string connectionString):base(connectionString)
        {

        }

        public void Select(string query)
        {
            using SqlCommand command = GetCommand();
            command.CommandText = query;

            var reader = command.ExecuteReader();

            while (reader.Read())
            {

            }
        }
    }
}
