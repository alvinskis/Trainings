using System;

namespace Exersice2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convert number to string, number max min 1 000 000

            Console.WriteLine("Enter the number");
            var number = int.Parse(Console.ReadLine());

            while(number <= -1000000 && number >= 1000000)
            {
                Console.WriteLine("Incorrect number format, please enter another one: ");
                number = int.Parse(Console.ReadLine());
            }

            bool isNegative = false;
            if(number < 0)
            {
                isNegative = true;

            }
        }
    }
}
