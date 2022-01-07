using System;

namespace ClassPractice
{
    class Student
    {
        //Field
        public string name;

        //Auto Property
        public DateTime DOB { get; set; }

        private double cgpa;

        //by default the access modifier will be private
        string address;

        protected int x;

        internal double y;

        public const double MAX_CGPA = 4.00;

        public readonly string StdID;

        //Property
        public double Cgpa
        {
            get
            {
                return cgpa;
            }

            set
            {
                if (value > 0)
                    cgpa = value;
            }
        }

        //Empty consructor
        //calling a constructor from another constructor
        public Student():this("Rahim Karim", "Dhaka", DateTime.MinValue)
        {
            StdID = name.ToUpper().Substring(0, 2) + DOB.Year;
        }


        //parameterized constructor
        public Student(string name, string Address, DateTime datetime)
        {
            //this keyword: only use when variable and parameter have same name
            this.name = name;

            DOB = datetime;

            address = Address;
        }

        //Method
        public void UpdateCGPA(double newCgpa)
        {
            cgpa = newCgpa;
        }
    }
}
