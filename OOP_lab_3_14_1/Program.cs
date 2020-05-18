using System;
using System.Collections.Specialized;
using System.Globalization;

namespace OOP_lab_3_14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string[] words = str.Split(new char[] { '\n', '\r', ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*', '/', '|' }, StringSplitOptions.RemoveEmptyEntries);

            str = "";

            for (int i = 0; i < words.Length; ++i)
            {
                if (words[i][0] != words[i][words[i].Length - 1])
                {
                    str += words[i] + " ";
                }
            }

            Console.WriteLine("\n{0}", str);

            words = str.Split(new char[] { '\n', '\r', ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*', '/', '|' }, StringSplitOptions.RemoveEmptyEntries);

            int[] count = new int[words.Length];

            for (int i = 0; i < count.Length; ++i)
            {
                count[i] = 1;
            }

            for (int i = 0; i < words.Length; ++i)
            {
                for (int j = i + 1; j < words.Length; ++j)
                {
                    if (words[i] == words[j])
                    {
                        ++count[i];

                        count[j] = -999999999;
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < count.Length; ++i)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine("{0} - {1}", words[i], count[i]);
                }
            }
        }
    }
}
