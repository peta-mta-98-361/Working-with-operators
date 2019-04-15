using System;

namespace Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
                x = 160;
                y = 50;

            //Addition
            Console.WriteLine("Addition : {0} + {1} = {2}", x, y, x + y);

            //Subtraction
            Console.WriteLine("Subtraction : {0} - {1} = {2}", x, y, x - y);

            //Multiplication
            Console.WriteLine("Multiplication : {0} * {1} = {2}", x, y, x * y);

            //Division
            Console.WriteLine("Division : {0} / {1} = {2}", x, y, x / y);

            //Modulo
            Console.WriteLine("Modulo : {0} % {1} = {2}", x, y, x % y);
        }
    }
}
