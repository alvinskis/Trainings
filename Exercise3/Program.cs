using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Working with random numbers
                Create a list
		        Add 100 random numbers
		        Delete numbers that are > 80
		        Print all even numbers in one line
		        Find how many numbers are < 20
		        Return all possible info about this list to screen (average, sum, count)
             */

            List<int> randomNumbers = new List<int>();
            var number = 0;
            while (number <= 100)
            {
                Random random = new Random();
                var randomNum = random.Next(1, 100);
                randomNumbers.Add(randomNum);
                number++;
            }
            Console.WriteLine("Random numbers: ");
            foreach (var rnd in randomNumbers)
            {
                Console.WriteLine(rnd);
            }

            Console.WriteLine("\nDeleted numbers which were more then 80: ");
            randomNumbers.RemoveAll(x => x > 80);
            foreach(var rnd in randomNumbers)
            {
                Console.WriteLine(rnd);
            }
            Console.Write("\nEven numbers: ");
            foreach(var even in randomNumbers)
            {
                if (even % 2 == 0)
                {
                    Console.Write($"{even} ");
                }
            }
            List<int> lessThenTwenty = new List<int>();
            foreach (var less in randomNumbers)
            {
                if (less < 20)
                {
                    lessThenTwenty.Add(less);
                }
            }
            Console.WriteLine($"\nNumbers less then 20 are: {lessThenTwenty.Count}");
            Console.WriteLine($"Count: {randomNumbers.Count}");
            Console.WriteLine($"Sum: {randomNumbers.Sum()}");
            Console.WriteLine($"Average: {randomNumbers.Average()}");
        }
    }
}
