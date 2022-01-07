using System;
using System.Collections.Generic;
using EntityFrameworkExample.DbContexts;
using EntityFrameworkExample.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkExample
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainingContext context = new TrainingContext();

            //Student std = new Student();
            //std.Name = "Kalam";
            //std.DateOfBirth = new DateTime(1993, 1, 14);
            //std.CGPA = 3.20;

            //context.Students.Add(std);
            //context.SaveChanges();

            //Course course = new Course();
            //course.Title = "C#";
            //course.Fees = 8000;
            //course.Topics = new List<Topic>();
            //course.Topics.Add(new Topic { Name = "Getting Started" });

            //context.Courses.Add(course);
            //context.SaveChanges();

            var course = context.Courses.Where(x => x.Id == 1)
                .Include("Topics")
                .FirstOrDefault();

            //Console.WriteLine($"Course Name: {course.Title}");

            //foreach(var topic in course.Topics)
            //{
            //    Console.WriteLine($"Topic Name: {topic.Name}");
            //}

            //var student = context.Students.Where(y => y.Id == 2).FirstOrDefault();

            //course.CourseStudents = new List<CourseStudents>();
            //course.CourseStudents.Add(new CourseStudents { Student = student });

            //context.SaveChanges();

            //var course = context.Courses
            //    .Include(a => a.CourseStudents)
            //    .ThenInclude(b => b.Student)
            //    .Include(c => c.Topics).ToList();

            //foreach(var cs in course)
            //{
            //    Console.WriteLine(cs.Title);

            //    foreach(var s in cs.CourseStudents)
            //    {
            //        Console.WriteLine(s.Student.Name);
            //    }

            //    foreach(var t in cs.Topics)
            //    {
            //        Console.WriteLine(t.Name);
            //    }
            //}
        }
    }
}
