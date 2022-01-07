using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityFunctions
{
    [Information(Description = "This class contains basic math functionality")]
    public class BasicMathFunctions
    {
        [Information(Description = "This method return the product of two numbers")]
        public double MultiplyOperation(double num1, double num2)
        {
            return num1 * num2;
        }

        [Information(Description = "This method return the division of two numbers")]
        public double DivideOperations(double num1, double num2)
        {
            return num1 / num2;
        } 
    }
}
