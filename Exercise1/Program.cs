using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list.Add to a list random words. Find which word is the longest, shortest.Find if in one of the words contains 'cat'
            List<string> list = new List<string>();
            Console.WriteLine("Insert words, press q when done");
            string input = "";

            string maxWord = "", minWord = "";
            int maxLength = int.MinValue, minLength = int.MaxValue;

            while ((input = Console.ReadLine()) != ("q"))
            {
                list.Add(input);

            }
            foreach (var item in list)
            {
                if (maxLength < item.Length)
                {
                    maxLength = item.Length;
                    maxWord = item;
                }
                if (minLength > item.Length)
                {
                    minLength = item.Length;
                    minWord = item;
                }
            }

            Console.WriteLine($"Max word: {maxWord}");
            Console.WriteLine($"Min word: {minWord}");

            foreach (var item in list)
            {
                if (item.Contains("cat"))
                {
                    Console.WriteLine($"Words with cat: {item}");
                }
            }
        }
    }
}
