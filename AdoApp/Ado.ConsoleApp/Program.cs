using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Ado.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Nuget Package: System.Configuration.ConfigurationManager
             * 
             */
            var connectionStr = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;
            //Store(connectionStr);
            //GetData(connectionStr);
            //GetDataTwo(connectionStr);
            //GetDataByStoredProc(connectionStr);
            //Destroy(connectionStr, 1);


            //FetchData fd = new FetchData(connectionStr);
            //var datas = fd.GetData();

            //foreach (DataRow dr in datas.Tables["Orders"].Rows)
            //{
            //    Console.WriteLine($"CustomerId: {dr["Customer_Id"]}, Total Amount: {dr["Amount"]}");
            //}

            //Console.WriteLine();
            //Console.WriteLine("Using Stored Procedure");
            //fd.GetDataById(1);

            //Console.WriteLine();
            //fd.StoreData();

            MyOrm<Student> students = new MyOrm<Student>(connectionStr);

            ////students.GetData();
            //foreach (var data in students.GetData())
            //{
            //    Console.WriteLine($"{data.Id}, {data.Name}");
            //}


            Student student = new Student()
            {
                Id = 8,
                Name = "Nick Jonas",
                Email = "nick@gmail.com",
                Join_Date = DateTime.Now
            };

            students.InsertItem(student);
        }

        public static void CreateTable()
        {
            SqlConnection con = null;

            try
            {
                var str = "Data Source=DESKTOP-UT6BOUK\\SQLEXPRESS;Initial Catalog=DB_Tmp;Integrated Security=True";
                con = new SqlConnection(str);

                var query = "create table Students(id int not null, name varchar(100), email varchar(50), join_date date)";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                cmd.ExecuteNonQuery();

                Console.WriteLine("Table Created Succesfully.");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Something went wrong {ex}");
            }
            finally
            {
                con.Close();
            }
        }

        public static void Store(string connectionString)
        {
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    var query = @"insert into Students (id, name, email, join_date) values 
                                (1, 'AN Rajin', 'rajin@gmail.com', '1/01/2022'), 
                                (2, 'John Snow', 'snow@gmail.com', '2/01/2022'),
                                (3, 'Jane Doe', 'jane@gmail.com', '5/11/2020'),
                                (4, 'Janiffer Joe', 'janiffer@gmail.com', '2/12/2021'),
                                (5, 'Bruce Wane', 'bruce@gmail.com', '1/10/2020')";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        Console.WriteLine("Record Successfully Inseted!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Something went wrong {ex}");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public static void GetData(string connectionString)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    var query = "Select name, email from Students";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();

                        using(SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                foreach(var col in sdr.GetColumnSchema())
                                {
                                    Console.WriteLine($"{col.ColumnName}: {sdr[col.ColumnName]}");
                                }
                                Console.WriteLine("----------------------------------------");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Something went wrong {ex}");
                }
                finally
                {
                    con.Close();
                }
            }
        }

        //Using SqlDataAdapter
        public static void GetDataTwo(string connectionString)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(connectionString))
                {
                    var query = "Select * from Students";

                    using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                    {
                        //using DataTable
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        Console.WriteLine("Using DataTable");
                        foreach(DataRow dr in dt.Rows)
                        {
                            Console.WriteLine(dr["name"]);
                        }
                        Console.WriteLine("---------------");


                        Console.WriteLine("Using DataSet");
                        using(DataSet ds = new DataSet())
                        {
                            sda.Fill(ds, "students");

                            foreach(DataRow dr in ds.Tables["students"].Rows)
                            {
                                Console.WriteLine(dr["email"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something thing went wrong {ex}");
            }
        }

        //Stored Procedure
        public static void GetDataByStoredProc(string connectionString)
        {
            try
            {
                Console.WriteLine("Using Store Procedure");

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("sp_GetStudents", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        Console.WriteLine(dr["email"]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void Destroy(string ConnectionString, int id)
        {
            using(SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    var query = $"Delete from Students where id = '{id}'";
                    
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        Console.WriteLine("Data successfully deleted");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Something thing went wrong {ex}");
                }
            }
        }
    }
}
