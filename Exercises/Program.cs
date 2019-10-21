using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to ask user for 10 integer numbers and display the even ones.
            //Write a program to ask user for 10 numbers and display average of the positive ones and negative ones.
            Console.WriteLine("Please insert 10 numbers");
            float[] numbers = new float[10];
            float sumNegative = 0;
            float sumPositive = 0;
            var countNegative = 0;
            var countPositive = 0;
        
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = float.Parse(Console.ReadLine());
            }
            foreach(var number in numbers)
            {
                if(number < 0)
                {
             
                    sumNegative += number;
                    countNegative += 1;
                }
                else if(number > 0)
                {
                    sumPositive += number;
                    countPositive += 1;
                }
            }
            if (countNegative > 0)
            {
                Console.WriteLine(sumNegative / countNegative);

            }
            if (sumPositive > 0)
            {
                Console.WriteLine(sumPositive / countPositive);
            }

            Array.Sort(numbers);
            foreach(var number in numbers)
            {
                Console.Write(number);
            }
        }
    }
}
