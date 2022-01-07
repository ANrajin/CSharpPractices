using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello World";
            int age = 24;
            double dollar = 10.25;
            bool isPublished = true;
            float floatNum = 8.56f;

            //0 -> 255
            byte byteNum = 255;


            // -128 -> 127
            sbyte sbyteNum = 127;

            // -32768 -> 32767
            short shortNum = -32768;

            //0 -> 65535
            ushort ushortNum = 65535;

            // -2147483648 -> 2147483647
            int intNum = 2147483647;

            //Console.WriteLine("Please Enter Something");

            //string msg = Console.ReadLine();

            //string[] parts = msg.Split('l');

            //Char[] toRemove = { 'H', 'e' };
            //string abc = msg.Trim(toRemove);

            //string xyz = msg.Substring(3);


            //Console.WriteLine(xyz);

            //for(int i = 0; i < parts.Length; i++)
            //{
            //    Console.WriteLine(parts[i]);
            //}

            //Console.WriteLine(abc);



            /*
             * value type
             * value type store the actual data
             * 
             * int, char, float, double, byte
             */
            int num = 24;
            int newNum = num;

            //this will not change the data of num variable
            newNum = 28;

            //Console.Write(num);



            /*
             * Reference type
             * hold the reference to the actual data
             * any change will affact the actual data
             * 
             * interface, class, string, object
             * 
             */
            Student std1 = new Student(24, "John");
            Student std2 = std1;

            //Console.WriteLine("Student id is {0} & name is {1}", std2.stdId, std2.stdName);

            std2.stdId = 28;
            std2.stdName = "Smith";

            //Console.WriteLine("Student id is {0} & name is {1}", std1.stdId, std1.stdName);


            //type convertion

            int newNumber = 125;
            //Console.WriteLine(newNumber.GetType());

            string intToStr = newNumber.ToString();

            //check the data type
            //Console.WriteLine(intToStr.GetType());
            //Console.WriteLine(intToStr);

            string numberNew = "225";
            int strToInt = Convert.ToInt32(numberNew);

            //Console.WriteLine(strToInt);

            //Console.WriteLine(strToInt.GetType());

            string newDoubleNum = "12.60";
            double strToDouble = Convert.ToDouble(newDoubleNum);

            //Console.WriteLine(strToDouble);
            //Console.WriteLine(strToDouble.GetType());

            float newfloat = 35.50f;

            //round a float to nearest upper/lower full number based on decimal
            int floatToInt = Convert.ToInt32(newfloat);

            //ignore the decimal, do not round a float number
            int floatToIntTwo = (int)newfloat;

            //Console.WriteLine(floatToInt);
            //Console.WriteLine(floatToIntTwo);



            /**
             * The properties of data types
             */
            string hw = "HeLLo doLLy";
            string str = "HelloWorld";

            Console.WriteLine("Original {0}", hw);

            hw = hw.ToLower();

            Console.WriteLine("ToLower: {0}", hw);

            hw = hw.ToUpper();

            Console.WriteLine("ToUpper: {0}", hw);

            hw = hw.Substring(2);

            Console.WriteLine("Substring: {0}", hw);


            int hwInt = str.IndexOf('o');

            Console.WriteLine("IndexOf: {0}", hwInt);

            bool isValid = true;
            string abcdef = isValid.ToString();

            //Console.WriteLine(abcdef);


            //Type Conversion
            int number = int.Parse(Console.ReadLine());
            int newNumberTwo = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(number);
            //Console.WriteLine(newNumberTwo);

            //String message = "Hello";
            //Console.Write(message);

            //Console.ReadKey();


            string abcd = "Hello World";

            int ind = abcd.IndexOf("l");

            Console.WriteLine(ind);
        }

        public class Student
        {
            public int stdId { get; set; }
            public string stdName { get; set; }

            public Student(int id, string name)
            {
                stdId = id;
                stdName = name;
            }
        }
    }
}
