using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ObjectToJson
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    ID = 102,
                    Name = "Musafir",
                    Age = 23,
                    DOB = new DateTime(1996, 05, 23)
                },
                new Student()
                {
                    ID = 101,
                    Name = "Ahad",
                    Age = 24,
                    DOB = new DateTime(1995, 11, 23)
                }
            };

            Student std = new Student()
            {
                ID = 101,
                Name = "Ahad",
                Age = 24,
                DOB = new DateTime(1995, 11, 23)
            };

            ObjectToJson(std);

            ObjectToFormattedJson(std);

            ListToJson(students);

            ObjectToUtf8String(students);

        }

        static void ObjectToJson(Student student)
        {
            Console.WriteLine("\nObject To Json");
            string strJson = JsonSerializer.Serialize<Student>(student);

            Console.WriteLine(strJson);
        }

        static void ObjectToFormattedJson(Student student)
        {
            Console.WriteLine("\nObject To Formatted Json");
            JsonSerializerOptions option = new JsonSerializerOptions() { WriteIndented = true };

            string strJson = JsonSerializer.Serialize<Student>(student, option);

            Console.WriteLine(strJson);
        }

        static void ListToJson(IList<Student> students)
        {
            Console.WriteLine("\nList to json");
            var options = new JsonSerializerOptions() { WriteIndented = true };

            string strJson = JsonSerializer.Serialize<IList<Student>>(students, options);

            Console.WriteLine(strJson);
        }

        static void ObjectToUtf8String(IList<Student> students)
        {
            Console.WriteLine("\nObject to utf8 string");
            byte[] utf8byte = JsonSerializer.SerializeToUtf8Bytes<IList<Student>>(students);
            string result = System.Text.Encoding.UTF8.GetString(utf8byte);

            Console.WriteLine(result);
        }
    }
}
