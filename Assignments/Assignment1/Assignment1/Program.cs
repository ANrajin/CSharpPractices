using System;
using System.Collections.Generic;
using System.Reflection;


namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
            course.Title = "Asp.net";
            course.Fees = 30000;
            course.Topics = new List<Topic>()
            {
                new Topic()
                {
                    Title = "Generics",
                    Description= "Generic List"
                },
                new Topic()
                {
                    Title = "Linq",
                    Description= "Using linq to perform something awesome"
                },
            };
            course.Tests = new List<AdmissionTest>
            {
                new AdmissionTest
                {
                    StartDateTime = new DateTime(2021, 10, 05),
                    EndDateTime = new DateTime(2021, 10, 10),
                    TestFees = 100
                },
                new AdmissionTest
                {
                    StartDateTime = new DateTime(2021, 09, 24),
                    EndDateTime = new DateTime(2021, 09, 30),
                    TestFees = 100
                }
            };

            string str = JsonFormatter<Course>.Converter(course);
            Console.WriteLine(str);

            //PropertyInfo[] properties = course.GetType().GetProperties();

            //foreach(PropertyInfo p in properties)
            //{
            //    if(p.PropertyType == typeof(DateTime))
            //    {
            //        Console.WriteLine(p.GetValue(course).ToString());
            //    }
            //}
        }
    }
}
