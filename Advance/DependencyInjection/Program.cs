using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new(new Car());
            driver.Drive();
        }
    }
}
