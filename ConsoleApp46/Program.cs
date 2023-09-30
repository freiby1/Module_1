using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите первое слово: ");
            string word1 = Console.ReadLine();

            Console.Write("Введите второе слово: ");
            string word2 = Console.ReadLine();

            List<char> uniqueChars = GetUniqueChars(word1, word2);

            Console.WriteLine("Буквы, которые есть только в одном из слов:");
            foreach (char c in uniqueChars)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
        }

        static List<char> GetUniqueChars(string word1, string word2)
        {
            List<char> uniqueChars = new List<char>();
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in word1)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            foreach (char c in word2)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            foreach (char c in charCount.Keys)
            {
                if (charCount[c] == 1)
                {
                    uniqueChars.Add(c);
                }
            }

            return uniqueChars;
        }
    }
}