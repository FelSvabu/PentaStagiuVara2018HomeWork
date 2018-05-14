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
            double calcul = (int) diffe.TotalDays / 365;
         
            Console.WriteLine("Insert your Gender (M/F): ");
            int? genderUser;
            string stringGender = Console.ReadLine().ToUpper();

            switch (stringGender)
            {
                case "F":
                    genderUser = (int?) Gender.Female;
                    break;
                case "M":
                    genderUser = (int?) Gender.Male;
                    break;
                default:
                    genderUser = null;
                    break;
            }

            if (genderUser == (int) Gender.Male && calcul < 65)
            {
                Console.WriteLine($"You have {65 - calcul} years until retirement");
            }
            else if (genderUser == (int) Gender.Male && calcul >= 65)
            {
                Console.WriteLine($"You are retired");
            }
            else if (genderUser == (int) Gender.Female && calcul < 63)
            {
                Console.WriteLine($"You have {63 - calcul} years until retirement");
            }
            else if (genderUser == (int) Gender.Male && calcul >= 63)
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
