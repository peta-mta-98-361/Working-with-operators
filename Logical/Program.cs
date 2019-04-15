using System;

namespace Logical
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int x, y;
            x = 10;
            y = 20;

            //OR

            result = (x == y) || (x > 5);
            Console.WriteLine(result);

            //AND

            result = (x == y) && (x > 5);
            Console.WriteLine(result);
        }
    }
}
