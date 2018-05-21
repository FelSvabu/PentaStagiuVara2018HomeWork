using System;

namespace Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstSentence = " Want to See the Wild Side of Cuba? ";
            string secondSentence = "How to Hire a Quality Private Tour Guide"; 
            string thirdSentence = "Places to Go in 2018";

            Console.WriteLine($"fisrt Sentence is: {firstSentence}");
            Console.WriteLine($"secondSentence is: {secondSentence}");
            Console.WriteLine($"thirdSentence is: {thirdSentence}");

            // Exemple 1
            int compare = string.Compare(firstSentence, secondSentence);
            Console.WriteLine($"\nfisrt sentence is {compare} smaller then second sentence \n");
           
            // Exemple 2
            CharEnumerator e = thirdSentence.GetEnumerator();
            while (e.MoveNext())
            {
                char c = e.Current;
                Console.WriteLine(c);
            }

            // Exemple 3

            string insert = thirdSentence.Insert(0, "52 ");
            Console.WriteLine(insert);
            
            // Exemple 4
            Console.WriteLine("\n Length of fisrst sentence is: " + firstSentence.Length);
           // Exemple 5
            string[] words = thirdSentence.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            // Exemple 6
            string lower = secondSentence.ToLower();
            Console.WriteLine($"\n lower: {lower} \n");
            // Exemple 7
            string remove = thirdSentence.Remove(7);
            Console.WriteLine($"remove from 7 palce: {remove}");
            Console.ReadKey();
        }
    }
}
