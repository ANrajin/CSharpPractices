using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPracticeTwo
{
    class Person
    {
        public string Name { get; set; }

        public DateTime DOB { get; set; }

        public string Address { get; set; }

        private readonly string idPrefix;

        public Person()
        {

        }

        public Person(string idPrefix)
        {
            this.idPrefix = idPrefix;
        }


        public string GenerateId()
        {
            if (!String.IsNullOrEmpty(Name))
                return $"{idPrefix}-{Name.Substring(0, 3)}";
            return null;
        }
    }
}
