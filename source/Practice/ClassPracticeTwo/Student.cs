using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPracticeTwo
{
    class Student:Person
    {
        //extending the constructor of parent class
        //base class contructor should be chained with the last constructor defined
        public Student():this("Rajin", "Dhaka") //default constructor
        {
        }

        public Student(string name, string address): base("STD") // parametarized constructor
        {

        }
    }
}
