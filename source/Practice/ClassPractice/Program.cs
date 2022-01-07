using System;

namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize a class
            Student student = new Student();

            student.name = "Rahim Karim";
            student.Cgpa = 3.46;
            student.DOB = new DateTime(1995, 05, 13);

            //update the cgpa
            student.UpdateCGPA(3.50);

            Student student2 = new Student();

            student2.name = "Karim Rahim";
            student2.Cgpa = 3.33;
            student2.DOB = new DateTime(1990, 02, 25);

            student2.UpdateCGPA(3.80);

            Console.WriteLine(student.Cgpa.ToString("0.00"));
            Console.WriteLine(student2.Cgpa.ToString("0.00"));

            Console.WriteLine(student.name);
            Console.WriteLine(student2.name);


            var circlearea = AreaCalculator.CircleArea(20.5);

            var racArea = AreaCalculator.RactangleArea(20.5, 20.5);

            Console.WriteLine(circlearea);
            Console.WriteLine(racArea);

        }
    }
}
