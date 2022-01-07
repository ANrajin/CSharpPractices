using System;
using CommonCode;

namespace ClassPracticeTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();

            std.Name = "Jane Doe";

            var id = std.GenerateId();

            Console.WriteLine(id);

            Teacher tech = new Teacher();

            tech.Name = "John Doe";

            id = tech.GenerateId();

            Console.WriteLine(id);

            Course course = new Course();

            course.Title = "C-Shrap Course";

            Console.WriteLine(course.Title);

            Course 
        }
    }
}
