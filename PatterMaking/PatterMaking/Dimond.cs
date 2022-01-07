using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterMaking
{
    public class Dimond
    {
        public void Run(int n)
        {
            #region half dimond
            for (var i = 1; i < 2 * n; i++)
            {
                int star = i;

                //if i greater then the row (n) number then we will decrease a star column
                if (i > n)
                {
                    star = (2 * n) - i;
                }

                for (var j = 1; j <= star; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("\n");
            }
            #endregion

            #region mirrored half diamond
            for (var i = 1; i <= 2 * n; i++)
            {
                for (var j = 1; j <= n; j++)
                {
                    if (j <= Math.Abs(n - i))
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine("\n");
            }
            #endregion

            #region Half dimond of numbers and stars
            for (var i = 1; i < n * 2; i++)
            {
                var col = i;

                if (i > n)
                {
                    col = Math.Abs(n * 2 - i);
                }

                for (var j = 1; j < col * 2; j++)
                {
                    if (j % 2 == 0)
                        Console.Write($"*");
                    else
                        Console.Write(col);
                }

                Console.WriteLine("\n");
            }
            #endregion

            #region Full Dimond with double row
            for (var i = 1; i < n; i++)
            {
                for (var j = 1; j < n - i; j++)
                {
                    Console.Write("  ");
                }

                for (var k = 1; k <= i * 2 - 1; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("\n");
            }

            for (var i = n - 1; i > 1; i--)
            {
                for (var j = 1; j <= Math.Abs(n - i); j++)
                {
                    Console.Write("  ");
                }

                for (var k = i * 2 - 2; k > 1; k--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("\n");
            }
            #endregion

            #region hollow diamond of numbers
            int a = 1;

            for(var i = 1; i<= n; i++)
            {
                for(var j = i; j <= n; j++)
                {
                    Console.Write("  ");
                }

                for(var k = 1; k <= 2*i-1; k++)
                {
                    if (k == 1 || k == 2 * i - 1)
                        Console.Write($"{a} ");
                    else
                        Console.Write("  ");
                }
                a++;
                Console.WriteLine("\n");
            }

            a = n - 1;

            for(var i = a; i >=1; i--)
            {
                for(int j = n; j>= i; j--)
                {
                    Console.Write("  ");
                }

                for(var k = 1; k <= 2*i-1; k++)
                {
                    if (k == 1 || k == 2 * i - 1)
                        Console.Write($"{a} ");
                    else
                        Console.Write("  ");
                }
                a--;
                Console.WriteLine("\n");
            }
            #endregion

            #region Full Dimond
            //for (var i = 1; i < n-1; i++)
            //{
            //    for (var j = 1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (var k = 1; k <= i * 2 - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("\n");
            //}

            //for(var i = 1; i < n-2; i++)
            //{
            //    for(var j = 1; j < (n*2)-(i*2); j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for(var k = i; k >= 1; k--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("\n");
            //}
            #endregion
        }
    }
}
