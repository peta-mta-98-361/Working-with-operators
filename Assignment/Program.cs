using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //Specify two variables x and y with a value of 45 and 90

            double x, y; 
                x = 45;
                y = 90;

            //Output to a console

            Console.WriteLine("The value of x is {0} and the value of y is {1}", x, y);

            //Initialise a new variable, z, which is assigned the value of x(45)
            
            double z;
                z = x;  //Outputs z = 45

            Console.WriteLine("The value of x is {0}, the value of y is {1} and the value of z is {2}", x, y, z);

            //Now set y as equal to z

                y = z;  //Outputs y = 45

            Console.WriteLine("The value of x is {0}, the value of y is {1} and the value of z is {2}", x, y, z);

        }
    }
}
