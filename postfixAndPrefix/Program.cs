using System;

namespace postfixAndPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 10;

            Console.WriteLine((x++));
            Console.WriteLine((x));

            x = 10;

            Console.WriteLine((++x));
            Console.WriteLine((x));
        }
    }
}
