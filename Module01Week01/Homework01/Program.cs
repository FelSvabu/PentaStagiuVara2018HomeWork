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
            Console.WriteLine("Guess the number");
            Random rndm = new Random();
            int number = rndm.Next(0, 100);
            int nr = 0;
            
            Console.WriteLine("Please insert a number bweteen 0 and 100");
            do
            {
                string str = Console.ReadLine();
                nr = int.Parse(str);
                if (nr > 100)
                {
                    Console.WriteLine("Inser a number bweteen 0 and 100");
                } else if (nr < number)
                {
                    Console.WriteLine("The riht number is bigger");
                }
                else if (nr == number)
                {
                    Console.WriteLine($"Congrtulation, the right number is {number}");
                }
                else
                {
                    Console.WriteLine("The right number is lower");
                }
            } while (nr != number);
        }
    }
}
