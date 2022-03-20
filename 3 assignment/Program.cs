using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_assignment
{
    internal class Program
    {
        //Please write a program, where you would create similar structure.Pass this structure into your own
        //created method and calculate the depth of provided structure.Main requirement to complete this
        //task: use recursion.

        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            int number = Convert.ToInt32(Console.ReadLine());
            double factorial = Factorial(number);
            Console.WriteLine($"Factorial of {number.ToString()} = {factorial.ToString()}");

            Console.ReadKey();
        }

        public static double Factorial(int number)
        {
            if ( number == 0)
                return 1;

            return number * Factorial(number - 1);
        }
    }
}
