using System;

namespace Unary
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, result;
            bool flag = true;

            result = +x;
            Console.WriteLine("+number = {0}", result);

            result = -x;
            Console.WriteLine("-number = {0}", result);

            result = ++x;
            Console.WriteLine("++number = {0}", result);

            result = --x;
            Console.WriteLine("--number = {0}", result);
        }
    }
}
