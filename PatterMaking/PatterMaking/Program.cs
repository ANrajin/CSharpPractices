using System;

namespace PatterMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Triangle tr = new Triangle();
            //tr.Run(n);

            //ReverseTriangle rt = new ReverseTriangle();
            //rt.Run(n);

            //Box b = new Box();
            //b.Run(n);

            //FloydTriangle ft = new FloydTriangle();
            //ft.Run(n);

            //EvenOddRow eor = new EvenOddRow();
            //eor.Run(n);

            //Pyramid p = new Pyramid();
            //p.Run(n);

            //OtherPatterns op = new OtherPatterns();
            //op.Run(n);

            Dimond d = new Dimond();
            d.Run(n);
        }
    }
}
