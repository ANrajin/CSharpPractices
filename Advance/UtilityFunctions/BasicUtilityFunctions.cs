using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityFunctions
{
    [Information(Description = "This class contains basic utility methods")]
    public class BasicUtilityFunctions
    {
        [Information(Description = "This method return a welcome message")]
        public string WriteWelcomeMessage()
        {
            return "Welcome to basic utility functions";
        }

        [Information(Description = "This method return the sum of two operands")]
        public int IntegerPlusInteger(int operand1, int operand2)
        {
            return operand1 + operand2;
        }

        [Information(Description = "This method concate three strings and return a new string")]
        public string ConcateThreeStrings(string str1, string str2, string str3)
        {
            return $"{str1} {str2} {str3}";
        }

        [Information(Description = "This method returns the length of specified string")]
        public int GetStringLength(string str)
        {
            return str.Length;
        }
    }
}
