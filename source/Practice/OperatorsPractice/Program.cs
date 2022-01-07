using System;

namespace OperatorsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            //Arithmatic operatiors: +,-, *, /, %

            int z = x + y;
            int m = x - y;
            int n = x * y;
            int o = y / x;
            int p = x % o;

            Console.WriteLine("addition : {0}", z);
            Console.WriteLine("subtraction : {0}", m);
            Console.WriteLine("multiplication : {0}", n);
            Console.WriteLine("division : {0}", o);
            Console.WriteLine("{1} modulas {2}: {0}", p, x, o);

            // +=, /=, *=, -=, %=
            p += y;
            Console.WriteLine($"value of p is {p}");

            m *= x;
            Console.WriteLine($"value of m is {m}");

            p %= x;

            Console.WriteLine($"value of p is {p}");


            //Increment & decrement oparators: ++, --
            int a = 20;
            int b = 36;

            //Do the increment operation first, then print the value
            Console.WriteLine($"before the execution of forward increment: {++a}");
            Console.WriteLine($"after the execution of forward increment: {a}");


            //print the value first, than do the increment operation
            Console.WriteLine($"before the execution of backward increment: {b++}");
            Console.WriteLine($"after the execution of backward increment: {b}");


            //Unary operator: are operators that act upon a single operand to produce a new value.
            //Unary plus (+), Unary negation (-), Increment (++), Decrement (--)
            //Logical NOT (!), Bitwise NOT (~)
            bool hasPassed = false;

            hasPassed = !hasPassed; //will return true

            Console.WriteLine(hasPassed);

            Console.WriteLine(+5);
            Console.WriteLine(-5);



            //Realtional operators
            // = , ==, !=, >, <, >=, <=


            //Logical operators
            // &&, ||, !



            //Bitwise Operators
            // ~, &, |, <<, >>, ^

            int t1 = 5; //binary: 101
            int t2 = 6; //binary: 110
            int t3 = t1 & t2; //4
            int t4 = t1 | t2; //7

            Console.WriteLine(t3);
            Console.WriteLine(t4);

            int b1 = 101; //represents: 5
            int b2 = 110; //represents: 6

            int b3 = b1 | b2; //binary: 111 = 7
            int b4 = b1 & b2; //binary: 100 = 4

            Console.WriteLine(b3);
            Console.WriteLine(b4);



            //	A Binary Digit can only be 0 or 1
            //each binary digits represent 1-bit

            // ~ = will replace 0 with 1 and 1 with 0
            // 0b represents that it is a binary number
            //0x represents that it is a hexadecimal number

            byte q = 0b_0011_1100; // remember 8 bits = 1 byte
            q = (byte)~q; //11000011

            Console.WriteLine(Convert.ToString(q, toBase: 2));

            short w = 0b_0100_1100_1011_1111; //16 bit signed integer
            w = (short)~w; // 1011_0011_0100_0000

            Console.WriteLine(Convert.ToString(w, toBase: 2));

            // Binary Left Shift (<<) Operator. The left operands value is moved left by the number of bits specified by the right operand.
            // it also multiply the left operand value by 2
            uint ls = 0b_1100_0011_1001_0110;

            Console.WriteLine(ls); //50070

            ls = ls << 2; //11_0000_1110_0101_1000

            Console.WriteLine(ls);//200280

            Console.WriteLine(Convert.ToString(ls, toBase: 2));


            //Binary Right Shift (>>) Operator. The left operands value is moved right by the number of bits specified by the right operand.
            // it also devide the left operand value by 2

            uint rs = 0b_1100_0011_1001_0110;

            Console.WriteLine(rs); //50070

            rs = rs >> 2;//0011_0000_1110_0101;

            Console.WriteLine(rs);//12517
            Console.WriteLine(Convert.ToString(rs, toBase: 2));


            //Binary XOR (^) Operator copies the bit if it is set in one operand but not both.
            //if the bits matches in both than it will give 0 and if not matched than 1

            int e = 0b_1001_1101;
            int f = 0b_0011_1001;

            int k = e ^ f; //1010_0100;

            Console.WriteLine(Convert.ToString(k, toBase: 2));
        }
    }
}
