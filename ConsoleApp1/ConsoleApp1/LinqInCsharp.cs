using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LinqInCsharp
    {
        IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13, StandardID =1} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21, StandardID =1 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID =2 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID =2} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 },
                new Student() { StudentID = 6, StudentName = "Abram" , Age = 21 },
                new Student() { StudentID = 7, StudentName = "Steve",  Age = 20 } ,
            };

        public List<Product> GetProductList() => Products.ProductList;

        public void Run()
        {
            //TestOne();
            //TestTwo();
            //OrderByTest();
            //ThenByTest();
            //GroupByTest();
            JoinTest();
        }

        private void JoinTest()
        {
            IList<Standard> standardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardName="Standard 1"},
                new Standard(){ StandardID = 2, StandardName="Standard 2"},
                new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };

            var result = from s in standardList
                         join p in studentList
                         on s.StandardID equals p.StandardID
                         select p.StudentName;

            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }

        private void GroupByTest()
        {
            //var result = from s in studentList group s by s.Age;
            //var result = studentList.GroupBy(s => s.Age); //Deffered execution           
            var result = studentList.ToLookup(s => s.Age); //immidiate execution

            foreach (var r in result)
            {
                Console.WriteLine($"{r.Key} years old:");

                foreach(var c in r)
                {
                    Console.WriteLine($"Name: {c.StudentName}");
                }

                Console.WriteLine("\n");
            }
        }

        private void ThenByTest()
        {
            var result = studentList.Where(s => s.StudentName.Contains('i'))
                .OrderBy(s => s.StudentName)
                .ThenBy(s => s.Age).ToArray<Student>();

            foreach(var s in result)
            {
                Console.WriteLine(s.StudentName);
            }

            Console.WriteLine("-----------------------------");

            result = studentList.Where(s => s.StudentName.Contains('n'))
            .OrderBy(s => s.StudentName)
            .ThenByDescending(s => s.Age).ToArray<Student>();

            foreach (var s in result)
            {
                Console.WriteLine(s.StudentName);
            }
        }

        private void OrderByTest()
        {
            var result = from s in studentList orderby s.StudentName select s;

            foreach(var student in result)
            {
                Console.WriteLine($"{student.StudentID}: {student.StudentName}");
            }

            Console.WriteLine("-----------------------------");

            var result2 = studentList.OrderByDescending(s => s.Age).ToList<Student>();

            foreach (var student in result2)
            {
                Console.WriteLine($"{student.StudentID}: {student.StudentName}");
            }

            Console.WriteLine("-----------------------------");

            var result3 = from s in studentList orderby s.StudentName, s.Age
                          select s;

            foreach (var student in result3)
            {
                Console.WriteLine($"{student.StudentID}: {student.StudentName}");
            }

        }

        private void TestOne()
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            //var result = from student in studentList 
            //             where student.Age >= 15 && student.Age <= 20
            //             select student;

            var result = studentList.Where(s => s.Age >= 15 && s.Age <= 20).ToList<Student>();

            foreach (var student in result)
            {
                Console.WriteLine(student.StudentName);
            }
        }

        private void TestTwo()
        {
            IList<string> stringList = new List<string>() {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java"
            };

            var result = from s in stringList where s.Contains("Tutorials") select s;

            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
        }
    }
}
