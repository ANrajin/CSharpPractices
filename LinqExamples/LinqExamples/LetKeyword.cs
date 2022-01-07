using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqExamples.DataSource;

namespace LinqExamples
{
    public class LetKeyword
    {
        //The 'let' keyword is useful in query syntax. It projects a new range variable,
        //allows re-use of the expression and makes the query more readable.

        public List<Student> GetStudents() => Studnets.StudentsList;

        #region Query-without-Let_keyword
        public void WithoutLet()
        {
            List<Student> students = GetStudents();

            var lowerCaseStudentsName = students.Where(s => s.StudentName.ToLower().StartsWith('r')).Select(s => s.StudentName.ToLower());

            foreach(var student in lowerCaseStudentsName)
            {
                Console.WriteLine(student);
            }
        }
        #endregion

        #region Query-with-let
        public void QueryWithLet()
        {
            List<Student> students = GetStudents();

            IEnumerable<string> lowerCaseStudentName = from s in students
                                                       let lowerCaseName = s.StudentName.ToLower()
                                                       where lowerCaseName.StartsWith("r")
                                                       select lowerCaseName;
            foreach(var lc in lowerCaseStudentName)
            {
                Console.WriteLine(lc);
            }
        }
        #endregion
    }
}
