using System;

namespace Relational
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result;
            int x, y;
            x = 40;
            y = 90;

            result = (x == y);
            Console.WriteLine("{0} == {1} returns {2}", x, y, result);

            result = (x > y);
            Console.WriteLine("{0} > {1} returns {2}", x, y, result);

            result = (x >= y);
            Console.WriteLine("{0} >= {1} returns {2}", x, y, result);

            result = (x < y);
            Console.WriteLine("{0} < {1} returns {2}", x, y, result);

            result = (x <= y);
            Console.WriteLine("{0} <= {1} returns {2}", x, y, result);

            result = (x != y);
            Console.WriteLine("{0} != {1} returns {2}", x, y, result);
        }
    }
}
