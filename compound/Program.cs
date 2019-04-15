using System;

namespace compound
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = 12;

            //+= is equivalent to number  = number + 5
            Console.WriteLine("Value of number = {0}", number);
            Console.WriteLine("\tnumber += 5 is equal to number + 5  = {0}", number += 5);
            Console.WriteLine("\tn is now {0}\n", number);

            //-= is equivalent to number  = number - 5
            Console.WriteLine("Value of number = {0}", number);
            Console.WriteLine("\tnumber -= 5 is equal to number - 5 =  {0}", number -= 5);
            Console.WriteLine("\tn is now {0}\n", number);

            //*= is equivalent to number  = number * 5
            Console.WriteLine("Value of number = {0}", number);
            Console.WriteLine("\tnumber *= 5 is equal to number * 5 = {0}", number *= 5);
            Console.WriteLine("\tn is now {0}\n", number);

            //This is equivalent to number  = number / 5
            Console.WriteLine("Value of number = {0}", number);
            Console.WriteLine("\tnumber /= 5 is equal to number / 5 = {0}", number /= 5);
            Console.WriteLine("\tn is now {0}\n", number);

            //This is equavalent to number = number % 5
            Console.WriteLine("Value of number = {0}", number);
            Console.WriteLine("\tnumber %= 5 is equal to number % 5 = {0}", number %= 5);
            Console.WriteLine("\tn is now {0}\n", number);

        }
    }
}
