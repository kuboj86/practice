using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = numberOne ("Please enter a number between 1-10.");

            if (number > 0 && number < 10)
                Console.WriteLine("Valid");
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        private static int numberOne(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            int number;
            if(Int32.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                return numberOne("please enter a valid number");
            }
        }
    }
}
