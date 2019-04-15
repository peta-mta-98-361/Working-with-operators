using System;

namespace ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 10;
            string result;

            result = (x % 2 == 0) ? "Even Number" : "Odd number";
            Console.WriteLine("{0} is {1}", x, result);
        }
    }
}
