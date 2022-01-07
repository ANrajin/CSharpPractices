using System;

namespace CF_339A
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faild
            string s = "3+2+1";

            string[] num = s.Split('+');

            for(var i = 0; i < num.Length; i++)
            {
                if(int.Parse(num[i]) > int.Parse(num[i + 1]))
                {
                    var t = num[i];
                    num[i] = num[i + 1];
                    num[i + 1] = t;
                }
            }

            Console.WriteLine(num);
        }
    }
}
