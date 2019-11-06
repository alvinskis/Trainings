using System;

namespace ConvNumToString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convert number to string, number max min 1 000 000

            Console.WriteLine("Enter the number");
            var number = int.Parse(Console.ReadLine());

            while (number <= -1000000 && number >= 1000000)
            {
                Console.WriteLine("Incorrect number format, please enter another one: ");
                number = int.Parse(Console.ReadLine());
            }

            bool isNegative = false;
            if (number < 0)
            {
                isNegative = true;
                number *= -1;
            }

            string[] firstCollection = new string[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                                                      "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
                                                      "eighteen", "nineteen"};
            string[] secondCollection = new string[] { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            string[] thirdCollection = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };


            if (number == 0)
            {
                Console.WriteLine("Zero");
            }
            else if (number % 10 != 0 && number < 10)
            {
                if (isNegative == true)
                {
                    Console.WriteLine("minus" + " " + firstCollection[number]);
                }
                else
                {
                    Console.WriteLine(firstCollection[number]);
                }
            }
            else if (number <= 19 && number >= 10)
            {
                number %= 10;
                if (isNegative == true)
                {
                    Console.WriteLine("minus" + " " + thirdCollection[number]);

                }
                else
                {
                    Console.WriteLine(thirdCollection[number]);

                }
            }
            else if (number > 20 && number < 100)
            {
                var first = number / 10;
                var second = number % 10;
                if (isNegative == true)
                {
                    Console.WriteLine("minus" + " " + secondCollection[first] + " " + firstCollection[second]);
                }
                else
                {
                    Console.WriteLine(secondCollection[first] + " " + firstCollection[second]);
                }
            }
            else if (number >= 100 && number < 1000)
            {
                var first = number / 100;
                var second = number % 100;
                var third = second / 10;
                var fourth = number % 10;
                if (isNegative == true)
                {
                    Console.WriteLine($"minus {firstCollection[first]} hundred {(second > 20 ? secondCollection[third] : firstCollection[second])} {(second > 20 ? firstCollection[fourth] : "")}");

                }
                else
                {
                    Console.WriteLine($"{firstCollection[first]} hundred {(second > 20 ? secondCollection[third] : firstCollection[second])} {(second > 20 ? firstCollection[fourth] : "")}");

                }
            }
            else if (number >= 1000 && number < 10000)
            {
                var first = number / 1000;
                var second = number % 1000;
                var third = second / 100;
                var fourth = second % 100;
                var fift = fourth / 10;
                var sixth = fourth % 10;
                if (third == 0)
                {
                    if (isNegative == true)
                    {
                        Console.WriteLine($"minus {firstCollection[first]} thousands {firstCollection[third]} {(fourth > 20 ? secondCollection[fift] : firstCollection[fourth])} {(fourth > 20 ? firstCollection[sixth] : "")}");
                    }
                    else
                    {
                        Console.WriteLine($"{firstCollection[first]} thousands {firstCollection[third]} {(fourth > 20 ? secondCollection[fift] : firstCollection[fourth])} {(fourth > 20 ? firstCollection[sixth] : "")}");
                    }
                }
                else
                {
                    if (isNegative == true)
                    {
                        Console.WriteLine($"minus {firstCollection[first]} thousands {firstCollection[third]} hundred {(fourth > 20 ? secondCollection[fift] : firstCollection[fourth])} {(fourth > 20 ? firstCollection[sixth] : "")}");
                    }
                    else
                    {
                        Console.WriteLine($"{firstCollection[first]} thousands {firstCollection[third]} hundred {(fourth > 20 ? secondCollection[fift] : firstCollection[fourth])} {(fourth > 20 ? firstCollection[sixth] : "")}");
                    }
                }
            }
            else if (number >= 10000 && number < 100000)
            {
                var first = number / 10000;
                var second = number % 10000;
                var third = second / 1000;
                var fourth = second % 1000;
                var fift = fourth / 100;
                var sixth = fourth % 100;
                var seveth = sixth / 10;
                var eith = sixth % 10;
                if (fift == 0)
                {
                    if (isNegative == true)
                    {
                        Console.WriteLine($"minus {secondCollection[first]} {firstCollection[third]} thousands {(sixth > 20 ? secondCollection[seveth] : firstCollection[sixth])} {(sixth > 20 ? firstCollection[eith] : "")}");
                    }
                    else
                    {
                        Console.WriteLine($"{secondCollection[first]} {firstCollection[third]} thousands {(sixth > 20 ? secondCollection[seveth] : firstCollection[sixth])} {(sixth > 20 ? firstCollection[eith] : "")}");
                    }
                }
                else
                {
                    if (isNegative == true)
                    {
                        Console.WriteLine($"minus {secondCollection[first]} {firstCollection[third]} thousands {firstCollection[fift]} hundred {(sixth > 20 ? secondCollection[seveth] : firstCollection[sixth])} {(sixth > 20 ? firstCollection[eith] : "")}");
                    }
                    else
                    {
                        Console.WriteLine($"{secondCollection[first]} {firstCollection[third]} thousands {firstCollection[fift]} hundred {(sixth > 20 ? secondCollection[seveth] : firstCollection[sixth])} {(sixth > 20 ? firstCollection[eith] : "")}");
                    }
                }
            }
            else if (number >= 100000 && number < 1000000)
            {
                var first = number / 100000;
                var second = number % 100000;
                var third = second / 1000;
                var fourth = second % 10000;
                var fift = fourth / 1000;
                var sixth = fourth % 1000;
                var seveth = sixth / 100;
                var eith = sixth % 100;
                var nine = eith / 10;
                var ten = eith % 10;

                if (seveth == 0)
                {
                    if (isNegative == true)
                    {
                        Console.WriteLine($"minus {firstCollection[first]} hundred {(third > 20 ? secondCollection[third] : firstCollection[third])} {(third > 20 ? firstCollection[third] : "")} thousands {firstCollection[seveth]} {(eith > 20 ? firstCollection[eith] : secondCollection[nine])} {(eith > 20 ? firstCollection[ten] : "")}");
                    }
                    else
                    {
                        Console.WriteLine($"{firstCollection[first]} hundred {(third > 20 ? secondCollection[third] : firstCollection[third])} {(third > 20 ? firstCollection[third] : "")} thousands {firstCollection[seveth]} {(eith > 20 ? firstCollection[eith] : secondCollection[nine])} {(eith > 20 ? firstCollection[ten] : "")}");
                    }
                }
                else
                {
                    if (isNegative == true)
                    {
                        Console.WriteLine($"minus {firstCollection[first]} hundred {(third > 20 ? secondCollection[third] : firstCollection[third])} {(third > 20 ? firstCollection[third] : "")} thousands {firstCollection[seveth]} hundred {(eith > 20 ? secondCollection[nine] : firstCollection[eith])} {(eith > 20 ? firstCollection[ten] : "")}");
                    }
                    else
                    {
                        Console.WriteLine($"{firstCollection[first]} hundred {(third > 20 ? secondCollection[third] : firstCollection[third])} {(third > 20 ? firstCollection[third] : "")} thousands {firstCollection[seveth]} hundred {(eith > 20 ? secondCollection[nine] : firstCollection[eith])} {(eith > 20 ? firstCollection[ten] : "")}");
                    }
                }

            }
        }
    }
}