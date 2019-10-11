using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("My book");
            book.AddGrade(89.1);
            book.AddGrade(78.9);
            book.AddGrade(65.4);

            var stats = book.GetStatistics();

            Console.WriteLine($"Lowest grade: {stats.Low}");
            Console.WriteLine($"Highest grade: {stats.High}");
            Console.WriteLine($"Average grade: {stats.Average}");
    
        }
    }
}