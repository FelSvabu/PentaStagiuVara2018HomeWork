using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the number\n");
            Random rndm = new Random();
            int number = rndm.Next(0, 100);
            int nr = 0;

            Console.WriteLine("Please insert a number bweteen 0 and 100");

            do
            {
                string str = Console.ReadLine();

                if (!int.TryParse(str, out nr))
                {
                    Console.WriteLine("Error. Enter a number please!!!!");
                }
                else if (nr < number)
                {
                    Console.WriteLine("The correct number is greater");
                }
                else if (nr == number)
                {
                    Console.WriteLine($"Congratulation, the correct number is {number}");
                }
                else
                {
                    Console.WriteLine("The correct number is lesser");
                }
            } while (nr != number);
        }
    }
}
