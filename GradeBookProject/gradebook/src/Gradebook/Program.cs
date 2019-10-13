using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            IBook book = new DiskBook("My book");
            book.GradeAdded += OnGradeAddded;

            EnterGrades(book);

            var stats = book.GetStatistics();

            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"Lowest grade: {stats.Low}");
            Console.WriteLine($"Highest grade: {stats.High}");
            Console.WriteLine($"Average grade: {stats.Average}");
            Console.WriteLine($"The letter grade is {stats.Letter}");

        }

        private static void EnterGrades(IBook book) 
        {
            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }
        }

        static void OnGradeAddded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }
    }
}