using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_LINQLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            Random rand = new Random();
            List<char> letters = new List<char>();

            var descending =
                from element in letters
                orderby element descending
                select element;

            var ascending =
                from element in letters
                orderby element ascending
                select element;

            for (int x = 0; x < 30; x++)
            {
                letters.Add(alphabet[rand.Next(0, 26)]);
            }

            Console.WriteLine("Generated List:");
            foreach (var letter in letters)
            {
                Console.Write($"{letter} ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Ascending Order:");
            foreach (var letter in ascending)
            {
                Console.Write($"{letter} ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Descending Order:");
            foreach (var letter in descending)
            {
                Console.Write($"{letter} ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Ascending Order, No Duplicates:");
            foreach (var letter in ascending.Distinct())
            {
                Console.Write($"{letter} ");
            }
            Console.WriteLine("\n");
        }
    }
}
