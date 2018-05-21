using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    class Program
    {
        public enum Gender
        {
            Female,
            Male
        }

        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;

            Console.WriteLine("Insert your birth day. Format: MM dd YYYY");
            string insertBirthDay = Console.ReadLine();
            DateTime birthDateTime = DateTime.Parse(insertBirthDay);

            TimeSpan diffe = now - birthDateTime;
            double calcul = (int)diffe.TotalDays / 365;

            Console.WriteLine("Insert your Gender (M/F): ");
            int? genderUser;
            string stringGender = Console.ReadLine().ToUpper();

            switch (stringGender)
            {
                case "F":
                    genderUser = (int?)Gender.Female;
                    break;
                case "M":
                    genderUser = (int?)Gender.Male;
                    break;
                default:
                    genderUser = null;
                    break;
            }

            if (genderUser == (int)Gender.Male && calcul < 65)
            {
                Console.WriteLine($"You have {65 - calcul} years until retirement");
            }
            else if (genderUser == (int)Gender.Male && calcul >= 65)
            {
                Console.WriteLine($"You are retired");
            }
            else if (genderUser == (int)Gender.Female && calcul < 63)
            {
                Console.WriteLine($"You have {63 - calcul} years until retirement");
            }
            else if (genderUser == (int)Gender.Male && calcul >= 63)
            {
                Console.WriteLine($"You are retired");
            }
            else
            {
                Console.WriteLine("Error");
            }


            //Varianta 2

            Console.WriteLine("\n \nVarianta 2");
            Console.WriteLine("Please, insert your age");

            Console.Write("year: ");
            string stringYear = Console.ReadLine();
            int year = int.Parse(stringYear);

            Console.Write("month: ");
            string stringMonth = Console.ReadLine();
            int month = int.Parse(stringMonth);

            Console.Write("day: ");
            string stringDay = Console.ReadLine();
            int day = int.Parse(stringDay);

            DateTime DateOfBirth = new DateTime(year, month, day);
            
            TimeSpan diff = now - DateOfBirth;
            int Age = (int) diff.TotalDays / 365;


            Console.WriteLine("Insert your Gender (M/F): ");
            int? gender;
            string stringGenderUser = Console.ReadLine().ToUpper();
            
            switch (stringGenderUser)
            {
                case "F":
                    gender = (int?) Gender.Female;
                    break;
                case "M":
                    gender = (int?) Gender.Male;
                    break;
                default:
                    gender = null;
                    break;
            }

            if (gender == (int) Gender.Male && Age < 65)
            {
                Console.WriteLine($"You have {65 - Age} years until retirement");
            }
            else if (genderUser == (int) Gender.Male && Age >= 65)
            {
                Console.WriteLine("You are retired");
            }
            else if (gender == (int) Gender.Female && Age < 63)
            {
                Console.WriteLine($"You have {63 - Age} years until retirement");
            }
            else if (gender == (int) Gender.Male && Age >= 63)
            {
                Console.WriteLine($"You are retired");
            }
            else
            {
                Console.WriteLine("Error");
                
            }
        }
    }
}
