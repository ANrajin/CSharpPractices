using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample.Entities
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //each topic belongs to a course
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
