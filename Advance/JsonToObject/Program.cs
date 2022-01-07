using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Reflection;
using System.Linq;

namespace JsonToObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //string json = "{\"ID\": 101, \"Email\": \"Rajin\", \"Age\": 25}";

            //Student student = JsonSerializer.Deserialize<Student>(json);

            //Console.WriteLine(student.ID);
            //Console.WriteLine(student.Name);

            //string jsonArray = "[{\"ID\": 101,\"Name\":\"IT\" }, {\"ID\": 102,\"Name\":\"Accounts\" }]";

            //Console.WriteLine("\n");

            //IList<Department> department = JsonSerializer.Deserialize<List<Department>>(jsonArray);

            //foreach(var dept in department)
            //{
            //    Console.WriteLine(dept.ID);
            //    Console.WriteLine(dept.Name);
            //}

            string[] str = File.ReadAllLines(@"F:\data.json");

            Deserialize<Person>(str);

            //Person p = Deserialize<Person>(str);
        }

        static void Deserialize<T>(string[] str)
        {
            Type type = typeof(T);
            PropertyInfo[] info = type.GetProperties();

            ConstructorInfo cInfo = type.GetConstructor(new Type[] { });
            var a = cInfo.Invoke(new object[] { });

            foreach(string s in str)
            {
                string y = s.Trim();
                if (y == "{" || y == "}" || y == "[" || y =="]")
                {
                    str = str.Where((s, i) => i != Array.IndexOf(str, s)).ToArray();
                    Deserialize<T>(str);
                }
                else
                {
                    string[] x = s.Trim().Split(':');

                    Console.WriteLine("========");
                    Console.WriteLine(s);

                    foreach (var p in x)
                    {
                        //string d = p.Trim();
                        //if (d == "{" || d == "}" || d == "[" || d == "]")
                        //{
                        //    str = str.Where((s, i) => i != Array.IndexOf(str, p)).ToArray();
                        //    Deserialize<T>(str);
                        //}
                        //else
                        //{
                        //    Console.WriteLine(p);
                        //}
                    }

                    //foreach (PropertyInfo inf in info)
                    //{
                    //    if (inf.Name.ToLower() == x[0].Replace("\"", "").Trim())
                    //    {
                    //        inf.SetValue(a, x[1].Replace("\"", "").Trim());
                    //    }
                    //}
                }
            }

            //return (T)a;
        }
    }
}
