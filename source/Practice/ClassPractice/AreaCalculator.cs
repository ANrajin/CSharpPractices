using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    public static class AreaCalculator
    {
        public static int count;
        public static string name;


        public static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double RactangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
