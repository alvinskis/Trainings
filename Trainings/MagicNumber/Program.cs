using System;

namespace MagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            MagicNumber test = new MagicNumber();
            var Start = test.DifferentDigits();
            var byTwo = test.MultiplyDigitsByTwo(Start);
            var byThree = test.MultiplyDigitsByThree(byTwo);
            var byFour = test.MultiplyDigitsByFour(byThree);
            var byFive = test.MultiplyDigitsByFive(byFour);
            var bySix = test.MultiplyDigitsBySix(byFive);
            Console.Write("Magic Number: ");
            foreach (var item in bySix)
            {
                Console.WriteLine(item);
            }
        }
    }
}
