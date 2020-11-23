using System;
using System.Collections.Generic;

namespace checkRepeating
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string word = Console.ReadLine();
            int count = 0;
            int letter_count = 0;
            List<char> letter_checker = new List<char>();

            for (int i = 0; i < word.Length; i++)
            {
                foreach (char letter in letter_checker)
                {
                    if(letter == word[i])
                    {
                        letter_count++;
                        break;
                    }
                }

                if (letter_count==0)
                {
                    letter_checker.Add(word[i]);
                }

                for (int j = 0; j < word.Length; j++)
                {
                    if (word[i]==word[j])
                    {
                        count++;
                    }
                }
                if (letter_count==0)
                {
                    Console.WriteLine($"{word[i]} - {count}");
                }
                

                count = 0;
                letter_count = 0;
            }
        }
    }
}
