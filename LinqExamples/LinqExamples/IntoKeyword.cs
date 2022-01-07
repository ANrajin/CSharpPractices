using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqExamples.DataSource;

namespace LinqExamples
{
    public class IntoKeyword
    {
        //into keyword in LINQ query to form a group or to continue a query after a select clause

        List<Student> GetStudent() => Studnets.StudentsList;

        public void UseIntoKeyword()
        {
            List<Student> students = GetStudent();

            var teenAgers = from s in students
                            where s.Age > 12 && s.Age < 18
                            select s into teenStudents
                            where teenStudents.StudentName.StartsWith("R")
                            select teenStudents;

            foreach(var t in teenAgers)
            {
                Console.WriteLine(t.StudentName);
            }
        }
    }
}
