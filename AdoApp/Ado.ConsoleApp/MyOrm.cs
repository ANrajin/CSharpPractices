using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ado.ConsoleApp
{
    public class MyOrm<T>
    {
        private readonly string _connectionString;
        public MyOrm(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IList<T> GetData()
        {
            List<T> getdata = new List<T>();
            Type type = typeof(T);

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                var query = $"Select * from {type.Name}s";
                using(SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    using(SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        getdata = ToDataList<T>(sdr);
                    }
                }
            }

            return getdata;
        }

        private List<T1> ToDataList<T1>(IDataReader sdr)
        {
            List<T1> getDataList = new List<T1>();

            T1 entity;
            Type type = typeof(T);
            PropertyInfo col;
            IEnumerable<PropertyInfo> propInfo = type.GetProperties();

            List<PropertyInfo> columns = new List<PropertyInfo>();

            for(var i = 0; i < sdr.FieldCount; i++)
            {
                col = propInfo.FirstOrDefault(c => c.Name.ToLower() == sdr.GetName(i).ToLower());
                if (col is not null)
                    columns.Add(col);
            }

            //Console.WriteLine(columns);

            //Loop through all records
            while (sdr.Read())
            {
                //Creates an instance of the specified type using the
                //constructor that best matches the specified parameters.
                entity = Activator.CreateInstance<T1>();

                //Console.WriteLine(entity);

                //Loop through colum to assignData
                for(var i = 0; i < columns.Count; i++)
                {
                    if (sdr[columns[i].Name].Equals(DBNull.Value))
                    {
                        columns[i].SetValue(entity, null, null);//set null value if column is empty
                    }
                    else
                    {
                        columns[i].SetValue(entity, sdr[columns[i].Name], null);//else set value to property
                    }
                }

                getDataList.Add(entity);
            }

            return getDataList;
        }

        public void InsertItem(T item)
        {
            Type type = item.GetType();

            var table = type.Name;
            IEnumerable<PropertyInfo> propertyInfos = type.GetProperties();

            var query = QueryBuilder<T>.Insert(item, table, propertyInfos);
            var queryParams = QueryBuilder<T>.GetParams(item, propertyInfos);

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    if(queryParams is not null)
                    {
                        foreach (var p in queryParams)
                            cmd.Parameters.Add(new SqlParameter(p.Key, p.Value));
                    }

                    cmd.ExecuteNonQuery();
                }
            }

            Console.WriteLine(query);
        }
    }
}
