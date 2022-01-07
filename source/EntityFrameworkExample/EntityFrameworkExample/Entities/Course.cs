using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkExample.Entities
{
    public class Course
    {
        public int Id { get; set; }
        [StringLength(250)]
        public string Title { get; set; }
        public double Fees { get; set; }
        //each course has many topics
        public List<Topic> Topics { get; set; }
        public List<CourseStudents> CourseStudents { get; set; }
    }
}
