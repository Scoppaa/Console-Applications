using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplications
{
    class Program
    {
        static void Main(string[] args)
        {
            ////=================================================
            ////Application Name: Hello World
            ////Description: Program that prints "Hello World!"
            ////=================================================
            //Console.WriteLine("Hello World!");
            //Console.ReadLine();

            //////=================================================
            //////application name: Casting
            //////description: A simple demonstration of explicit type conversion.
            //////=================================================
            //double d = 423.64;
            //int i;

            //i = (int)d;
            //Console.WriteLine(i);
            //Console.ReadLine();

            ////=================================================
            ////Application Name: TwoFer
            ////Description: Takes a name from user input and places into sentance
            ////=================================================
            //Console.WriteLine("Enter a name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("One for " + name + ", one for me");
            //Console.ReadLine();

            ////=================================================
            ////Application Name: Leap
            ////Description: Takes a year as input and reports if its a leap year
            ////=================================================
            //Console.WriteLine("Enter a year");
            //int year = Convert.ToInt32(Console.ReadLine());
            //if (year % 4 == 0)
            //{
            //    Console.WriteLine(year + " is a leap year");
            //}
            //else
            //{
            //    Console.WriteLine(year + " is not a leap year");
            //}
            //Console.ReadLine();

            ////=================================================
            ////Application Name: Resistor
            ////Description: Creates an array of colors and allows the user to search for the index of it in the array
            ////=================================================
            //string[] resistor = new string[] { "Red", "Blue", "White", "Black", "Orange", "Green" };
            //Console.WriteLine("Enter a resistor color to return its numeric representation");
            //string color = Console.ReadLine();
            //int index = Array.FindIndex(resistor, x => x.Contains(color)); //Find index in the array of the color
            //Console.WriteLine("The numeric representation of " + color + " is: " + index);
            //Console.ReadLine();

            ////=================================================
            ////Application Name: Collatz Conjecture
            ////Description: The collatz conjecture will be printed for the user inputted number
            ////=================================================
            //Console.WriteLine("Enter a number to generate the collatz sequence");
            //int number= Convert.ToInt32(Console.ReadLine());
            //while (number != 1)
            //{
            //    if (number % 2 == 0) //If Even
            //    {
            //        number = number / 2;
            //    }
            //    else if (number % 2 == 1) //If Odd
            //    {
            //        number = 3 * number + 1;
            //    }
            //    Console.WriteLine(number);
            //}
            //    Console.ReadLine();
        }
    }
}
