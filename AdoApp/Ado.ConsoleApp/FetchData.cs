using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.ConsoleApp
{
    public class FetchData
    {
        private readonly string _connectionString;

        public FetchData(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataSet GetData()
        {
            /**
             *  ADO.NET DataSet is a collection of data tables that contains the relational data in memory in tabular format.
             *  It does not require a continuous open or active connection to the database. The DataSet is based on the disconnected architecture.
             */

            DataSet dataSet = new DataSet();

            /*
             * Create Customer Table
             */
            DataTable customers = new DataTable("customers");
            DataTable orders = new DataTable("Orders"); 

            //Add Columns
            DataColumn CustomerId = new DataColumn("Id", typeof(Int32));
            DataColumn CustomerName = new DataColumn("Name", typeof(string));
            DataColumn CustomerEmail = new DataColumn("Email", typeof(string));

            DataColumn OrderId = new DataColumn("Id", typeof(Int32));
            DataColumn CustId = new DataColumn("Customer_Id", typeof(Int32));
            DataColumn OrderAmount = new DataColumn("Amount", typeof(Double));

            customers.Columns.Add(CustomerId);
            customers.Columns.Add(CustomerName);
            customers.Columns.Add(CustomerEmail);

            orders.Columns.Add(OrderId);
            orders.Columns.Add(CustId);
            orders.Columns.Add(OrderAmount);

            //Add Data Rows
            customers.Rows.Add(1, "John Doe", "john@gmail.com");
            customers.Rows.Add(2, "Rose Watson", "rose@gmail.com");
            customers.Rows.Add(3, "James Tyson", "james@gmail.com");

            orders.Rows.Add(1, 2, 200.00);
            orders.Rows.Add(2, 1, 800.00);
            orders.Rows.Add(1, 3, 2100.00);
            orders.Rows.Add(1, 2, 1200.00);
            orders.Rows.Add(1, 1, 300.00);

            //Add Table to DataSet
            dataSet.Tables.Add(customers);
            dataSet.Tables.Add(orders);

            return dataSet;
        }

        public void GetDataById(int Id)
        {
            //using Stored Procedure
            try
            {
                using(SqlConnection con = new SqlConnection(_connectionString))
                {
                    using(SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "sp_GetStudentById";
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter param1 = new SqlParameter()
                        {
                            ParameterName = "@Id",
                            SqlDbType = SqlDbType.Int, //parameter Data type
                            Value = Id,
                            Direction = ParameterDirection.Input //specify the parameter as input
                        };

                        //add the parameter to sql command object
                        cmd.Parameters.Add(param1);
                        con.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            Console.WriteLine($"Name: {sdr["Name"]}, Email: {sdr["Email"]}");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void StoreData()
        {
            using(SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand()
                {
                    CommandText = "sp_CreateStudent",
                    Connection = con,
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter param1 = new SqlParameter()
                {
                    ParameterName = "@StdId",
                    SqlDbType = SqlDbType.Int,
                    Value = 6,
                    Direction = ParameterDirection.Input
                };

                SqlParameter param2 = new SqlParameter()
                {
                    ParameterName = "@Name",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = "Mark Wales",
                    Direction = ParameterDirection.Input
                };

                SqlParameter param3 = new SqlParameter()
                {
                    ParameterName = "@Email",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = "mark@gmail.com",
                    Direction = ParameterDirection.Input
                };

                cmd.Parameters.AddWithValue("@Join", DateTime.Now);

                SqlParameter outParam = new SqlParameter()
                {
                    ParameterName = "@Id",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };

                cmd.Parameters.Add(param1);
                cmd.Parameters.Add(param2);
                cmd.Parameters.Add(param3);
                cmd.Parameters.Add(outParam);

                con.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine(outParam.Value.ToString());
            }
        }
    }
}
