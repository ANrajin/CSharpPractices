using SOLID_Principles_in_CSharp.SRP;
using System;

namespace SOLID_Principles_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            IInputOutputProcessor input = new ConsoleInputOutput();

            var n = input.TakeInput();

            var primes = PrimeGenerator.Generate(n);

            foreach(var prime in primes)
            {
                input.WriteOutput($"{prime} is a prime number");
            }
        }
    }
}
