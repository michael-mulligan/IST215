using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_LINQWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a sentence: ");
            string sentence = Console.ReadLine();

            Console.WriteLine($"\nYou entered: \n{sentence}\n");

            String[] sentenceArray = sentence.ToLower().Split();

            var sortedWords =
                from word in sentenceArray
                orderby word
                select word;

            Console.Write("Distinct words: ");
            foreach (var i in sortedWords.Distinct())
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
