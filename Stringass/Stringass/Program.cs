using System;
using System.Diagnostics.Tracing;

namespace Stringass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[6];
            Console.WriteLine("Enter the Strings:");
            for(int i = 0; i < words.Length; i++)
            {
                 words[i] = Console.ReadLine();
            }
            string small = words[0];
            for(int i=0;i<words.Length;i++)
            {
                if (words[i].Length<small.Length)
                {
                    small = words[i];
                }
            }
            Console.WriteLine($" The shortest word in the list is {small}");
            Console.WriteLine("enter the word to search");
            string s2 = Console.ReadLine();
            bool found = false;
            for(int i = 0; i < words.Length; i++)
            {
                if (s2 == words[i])
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine($" The word is present in the list {s2}");
            }
            else
            {
                Console.WriteLine($" The word is not present in the list {s2}");
            }
            Array.Sort(words);
            Console.WriteLine("The stored array is");
            foreach(string item in words)
            {
                Console.WriteLine(item);
            }
            int pc = 0;
            string pwords = "";
            for(int i = 0; i < words.Length; i++)
            {
                string rwords = "";
                for (int j = words[i].Length - 1; j >= 0; j--)
                {
                    rwords += words[i][j];
                }
                if (words[i]==rwords)
                {
                    pc++;
                    pwords += words[i]+" ";
                }
            }
            if (pc > 0)
            {
                Console.WriteLine("the number of palindromes in the list " + pc);
                Console.WriteLine(pwords);
            }
            else
            {
                Console.WriteLine("there are no palindromes in the list");
            }
        }
    }
}