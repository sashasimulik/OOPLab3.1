using System;

namespace OOP_lab_3_18_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { '\n', '\r', ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*', '/', '|' }, StringSplitOptions.RemoveEmptyEntries);

            string longestWord = words[0];

            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            string str = "";

            foreach (string word in words)
            {
                int k = 0;

                foreach (char leter in word)
                {
                    for (char c = 'a'; c <= 'z'; ++c)
                    {
                        if (leter == c)
                        {
                            ++k;
                        }
                    }

                    for (char c = 'A'; c <= 'Z'; ++c)
                    {
                        if (leter == c)
                        {
                            ++k;
                        }
                    }
                }

                if (k != word.Length)
                {
                    str += word + " ";
                }
            }

            Console.WriteLine("\n{0}", str);
            Console.WriteLine("\nНайдовше слово: {0}", longestWord);
        }
    }
}
