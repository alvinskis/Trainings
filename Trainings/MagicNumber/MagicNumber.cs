using System;
using System.Collections.Generic;
using System.Text;

namespace MagicNumber
{
    public class MagicNumber
    {
        public List<int> DifferentDigits()
        {
            List<int> test = new List<int>();
            int startOfArray = 100000;
            int endOfArray = 999999;
            int[] arrayOfNumbers = new int[endOfArray - startOfArray + 1];
            int index = 0;
            for (int i = startOfArray; i <= endOfArray; i++)
            {
                arrayOfNumbers[index] = i;
                int num;
                Int32.TryParse(string.Join("", arrayOfNumbers[index]), out num);

                int firstNumber = num / 100000;
                int num1 = num % 100000;
                int secondNumber = num1 / 10000;
                int num2 = num1 % 10000;
                int thirdNumber = num2 / 1000;
                int num3 = num2 % 1000;
                int fourthNumber = num3 / 100;
                int num4 = num3 % 100;
                int fifthNumber = num4 / 10;
                int sixthNumber = num4 % 10;
                if (firstNumber != secondNumber && firstNumber != thirdNumber && firstNumber != fourthNumber && firstNumber != fifthNumber && firstNumber != sixthNumber)
                {
                    if (secondNumber != thirdNumber && secondNumber != fourthNumber && secondNumber != fifthNumber && secondNumber != sixthNumber)
                    {
                        if (thirdNumber != fourthNumber && thirdNumber != fifthNumber && thirdNumber != sixthNumber)
                        {
                            if (fourthNumber != fifthNumber && fourthNumber != sixthNumber)
                            {
                                if (fifthNumber != sixthNumber)
                                {
                                    test.Add(num);
                                }
                            }
                        }
                    }
                }
                index += 1;
            }
            return test;
        }

        public List<int> MultiplyDigitsByTwo(List<int> differentDigits)
        {
            int[] newArray = new int[6];
            List<int> test = new List<int>();
            for (int i = 0; i < differentDigits.Count; i++)
            {
                int num;
                Int32.TryParse(string.Join("", differentDigits[i]), out num);

                //Origin
                int firstNumber = num / 100000;
                int num1 = num % 100000;
                int secondNumber = num1 / 10000;
                int num2 = num1 % 10000;
                int thirdNumber = num2 / 1000;
                int num3 = num2 % 1000;
                int fourthNumber = num3 / 100;
                int num4 = num3 % 100;
                int fifthNumber = num4 / 10;
                int sixthNumber = num4 % 10;

                newArray[0] = firstNumber;
                newArray[1] = secondNumber;
                newArray[2] = thirdNumber;
                newArray[3] = fourthNumber;
                newArray[4] = fifthNumber;
                newArray[5] = sixthNumber;

                //MultiplyByTwo
                int multiplyByTwo = num * 2;
                int firstNumberByTwo = multiplyByTwo / 100000;
                int num1ByTwo = multiplyByTwo % 100000;
                int secondNumberByTwo = num1ByTwo / 10000;
                int num2ByTwo = num1ByTwo % 10000;
                int thirdNumberByTwo = num2ByTwo / 1000;
                int num3ByTwo = num2ByTwo % 1000;
                int fourthNumberByTwo = num3ByTwo / 100;
                int num4ByTwo = num3ByTwo % 100;
                int fifthNumberByTwo = num4ByTwo / 10;
                int sixthNumberByTwo = num4ByTwo % 10;

                if (newArray[0] == firstNumberByTwo || newArray[0] == secondNumberByTwo || newArray[0] == thirdNumberByTwo || newArray[0] == fourthNumberByTwo || newArray[0] == fifthNumberByTwo || newArray[0] == sixthNumberByTwo)
                {
                    if (newArray[1] == firstNumberByTwo || newArray[1] == secondNumberByTwo || newArray[1] == thirdNumberByTwo || newArray[1] == fourthNumberByTwo || newArray[1] == fifthNumberByTwo || newArray[1] == sixthNumberByTwo)
                    {
                        if (newArray[2] == firstNumberByTwo || newArray[2] == secondNumberByTwo || newArray[2] == thirdNumberByTwo || newArray[2] == fourthNumberByTwo || newArray[2] == fifthNumberByTwo || newArray[2] == sixthNumberByTwo)
                        {
                            if (newArray[3] == firstNumberByTwo || newArray[3] == secondNumberByTwo || newArray[3] == thirdNumberByTwo || newArray[3] == fourthNumberByTwo || newArray[3] == fifthNumberByTwo || newArray[3] == sixthNumberByTwo)
                            {
                                if (newArray[4] == firstNumberByTwo || newArray[4] == secondNumberByTwo || newArray[4] == thirdNumberByTwo || newArray[4] == fourthNumberByTwo || newArray[4] == fifthNumberByTwo || newArray[4] == sixthNumberByTwo)
                                {
                                    if (newArray[5] == firstNumberByTwo || newArray[5] == secondNumberByTwo || newArray[5] == thirdNumberByTwo || newArray[5] == fourthNumberByTwo || newArray[5] == fifthNumberByTwo || newArray[5] == sixthNumberByTwo)
                                    {
                                        if (firstNumber != firstNumberByTwo && secondNumber != secondNumberByTwo && thirdNumber != thirdNumberByTwo && fourthNumber != fourthNumberByTwo && fifthNumber != fifthNumberByTwo && sixthNumber != sixthNumberByTwo)
                                        {
                                            test.Add(num);
                                        }

                                    }

                                }

                            }

                        }
 

                    }
                }
            }
            return test;
        }

        public List<int> MultiplyDigitsByThree(List<int> differentDigits)
        {
            int[] newArray = new int[6];
            List<int> test = new List<int>();
            for (int i = 0; i < differentDigits.Count; i++)
            {
                int num;
                Int32.TryParse(string.Join("", differentDigits[i]), out num);

                //Origin
                int firstNumber = num / 100000;
                int num1 = num % 100000;
                int secondNumber = num1 / 10000;
                int num2 = num1 % 10000;
                int thirdNumber = num2 / 1000;
                int num3 = num2 % 1000;
                int fourthNumber = num3 / 100;
                int num4 = num3 % 100;
                int fifthNumber = num4 / 10;
                int sixthNumber = num4 % 10;

                newArray[0] = firstNumber;
                newArray[1] = secondNumber;
                newArray[2] = thirdNumber;
                newArray[3] = fourthNumber;
                newArray[4] = fifthNumber;
                newArray[5] = sixthNumber;

                //MultiplyByThree
                int multiplyByThree = num * 3;
                int firstNumberByThree = multiplyByThree / 100000;
                int num1ByThree = multiplyByThree % 100000;
                int secondNumberByThree = num1ByThree / 10000;
                int num2ByThree = num1ByThree % 10000;
                int thirdNumberByThree = num2ByThree / 1000;
                int num3ByThree = num2ByThree % 1000;
                int fourthNumberByThree = num3ByThree / 100;
                int num4ByThree = num3ByThree % 100;
                int fifthNumberByThree = num4ByThree / 10;
                int sixthNumberByThree = num4ByThree % 10;

                if (newArray[0] == firstNumberByThree || newArray[0] == secondNumberByThree || newArray[0] == thirdNumberByThree || newArray[0] == fourthNumberByThree || newArray[0] == fifthNumberByThree || newArray[0] == sixthNumberByThree)
                {
                    if (newArray[1] == firstNumberByThree || newArray[1] == secondNumberByThree || newArray[1] == thirdNumberByThree || newArray[1] == fourthNumberByThree || newArray[1] == fifthNumberByThree || newArray[1] == sixthNumberByThree)
                    {
                        if (newArray[2] == firstNumberByThree || newArray[2] == secondNumberByThree || newArray[2] == thirdNumberByThree || newArray[2] == fourthNumberByThree || newArray[2] == fifthNumberByThree || newArray[2] == sixthNumberByThree)
                        {
                            if (newArray[3] == firstNumberByThree || newArray[3] == secondNumberByThree || newArray[3] == thirdNumberByThree || newArray[3] == fourthNumberByThree || newArray[3] == fifthNumberByThree || newArray[3] == sixthNumberByThree)
                            {
                                if (newArray[4] == firstNumberByThree || newArray[4] == secondNumberByThree || newArray[4] == thirdNumberByThree || newArray[4] == fourthNumberByThree || newArray[4] == fifthNumberByThree || newArray[4] == sixthNumberByThree)
                                {
                                    if (newArray[5] == firstNumberByThree || newArray[5] == secondNumberByThree || newArray[5] == thirdNumberByThree || newArray[5] == fourthNumberByThree || newArray[5] == fifthNumberByThree || newArray[5] == sixthNumberByThree)
                                    {
                                        if (firstNumber != firstNumberByThree && secondNumber != secondNumberByThree && thirdNumber != thirdNumberByThree && fourthNumber != fourthNumberByThree && fifthNumber != fifthNumberByThree && sixthNumber != sixthNumberByThree)
                                        {
                                            test.Add(num);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return test;
        }

        public List<int> MultiplyDigitsByFour(List<int> differentDigits)
        {
            int[] newArray = new int[6];
            List<int> test = new List<int>();
            for (int i = 0; i < differentDigits.Count; i++)
            {
                int num;
                Int32.TryParse(string.Join("", differentDigits[i]), out num);

                //Origin
                int firstNumber = num / 100000;
                int num1 = num % 100000;
                int secondNumber = num1 / 10000;
                int num2 = num1 % 10000;
                int thirdNumber = num2 / 1000;
                int num3 = num2 % 1000;
                int fourthNumber = num3 / 100;
                int num4 = num3 % 100;
                int fifthNumber = num4 / 10;
                int sixthNumber = num4 % 10;

                newArray[0] = firstNumber;
                newArray[1] = secondNumber;
                newArray[2] = thirdNumber;
                newArray[3] = fourthNumber;
                newArray[4] = fifthNumber;
                newArray[5] = sixthNumber;

                //MultiplyByFour
                int multiplyByFour = num * 4;
                int firstNumberByFour = multiplyByFour / 100000;
                int num1ByFour = multiplyByFour % 100000;
                int secondNumberByFour = num1ByFour / 10000;
                int num2ByFour = num1ByFour % 10000;
                int thirdNumberByFour = num2ByFour / 1000;
                int num3ByFour = num2ByFour % 1000;
                int fourthNumberByFour = num3ByFour / 100;
                int num4ByFour = num3ByFour % 100;
                int fifthNumberByFour = num4ByFour / 10;
                int sixthNumberByFour = num4ByFour % 10;

                if (newArray[0] == firstNumberByFour || newArray[0] == secondNumberByFour || newArray[0] == thirdNumberByFour || newArray[0] == fourthNumberByFour || newArray[0] == fifthNumberByFour || newArray[0] == sixthNumberByFour)
                {
                    if (newArray[1] == firstNumberByFour || newArray[1] == secondNumberByFour || newArray[1] == thirdNumberByFour || newArray[1] == fourthNumberByFour || newArray[1] == fifthNumberByFour || newArray[1] == sixthNumberByFour)
                    {
                        if (newArray[2] == firstNumberByFour || newArray[2] == secondNumberByFour || newArray[2] == thirdNumberByFour || newArray[2] == fourthNumberByFour || newArray[2] == fifthNumberByFour || newArray[2] == sixthNumberByFour)
                        {
                            if (newArray[3] == firstNumberByFour || newArray[3] == secondNumberByFour || newArray[3] == thirdNumberByFour || newArray[3] == fourthNumberByFour || newArray[3] == fifthNumberByFour || newArray[3] == sixthNumberByFour)
                            {
                                if (newArray[4] == firstNumberByFour || newArray[4] == secondNumberByFour || newArray[4] == thirdNumberByFour || newArray[4] == fourthNumberByFour || newArray[4] == fifthNumberByFour || newArray[4] == sixthNumberByFour)
                                {
                                    if (newArray[5] == firstNumberByFour || newArray[5] == secondNumberByFour || newArray[5] == thirdNumberByFour || newArray[5] == fourthNumberByFour || newArray[5] == fifthNumberByFour || newArray[5] == sixthNumberByFour)
                                    {
                                        if (firstNumber != firstNumberByFour && secondNumber != secondNumberByFour && thirdNumber != thirdNumberByFour && fourthNumber != fourthNumberByFour && fifthNumber != fifthNumberByFour && sixthNumber != sixthNumberByFour)
                                        {
                                            test.Add(num);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return test;
        }

        public List<int> MultiplyDigitsByFive(List<int> differentDigits)
        {
            int[] newArray = new int[6];
            List<int> test = new List<int>();
            for (int i = 0; i < differentDigits.Count; i++)
            {
                int num;
                Int32.TryParse(string.Join("", differentDigits[i]), out num);

                //Origin
                int firstNumber = num / 100000;
                int num1 = num % 100000;
                int secondNumber = num1 / 10000;
                int num2 = num1 % 10000;
                int thirdNumber = num2 / 1000;
                int num3 = num2 % 1000;
                int fourthNumber = num3 / 100;
                int num4 = num3 % 100;
                int fifthNumber = num4 / 10;
                int sixthNumber = num4 % 10;

                newArray[0] = firstNumber;
                newArray[1] = secondNumber;
                newArray[2] = thirdNumber;
                newArray[3] = fourthNumber;
                newArray[4] = fifthNumber;
                newArray[5] = sixthNumber;

                //MultiplyByFive
                int multiplyByFive = num * 5;
                int firstNumberByFive = multiplyByFive / 100000;
                int num1ByFive = multiplyByFive % 100000;
                int secondNumberByFive = num1ByFive / 10000;
                int num2ByFive = num1ByFive % 10000;
                int thirdNumberByFive = num2ByFive / 1000;
                int num3ByFive = num2ByFive % 1000;
                int fourthNumberByFive = num3ByFive / 100;
                int num4ByFive = num3ByFive % 100;
                int fifthNumberByFive = num4ByFive / 10;
                int sixthNumberByFive = num4ByFive % 10;

                if (newArray[0] == firstNumberByFive || newArray[0] == secondNumberByFive || newArray[0] == thirdNumberByFive || newArray[0] == fourthNumberByFive || newArray[0] == fifthNumberByFive || newArray[0] == sixthNumberByFive)
                {
                    if (newArray[1] == firstNumberByFive || newArray[1] == secondNumberByFive || newArray[1] == thirdNumberByFive || newArray[1] == fourthNumberByFive || newArray[1] == fifthNumberByFive || newArray[1] == sixthNumberByFive)
                    {
                        if (newArray[2] == firstNumberByFive || newArray[2] == secondNumberByFive || newArray[2] == thirdNumberByFive || newArray[2] == fourthNumberByFive || newArray[2] == fifthNumberByFive || newArray[2] == sixthNumberByFive)
                        {
                            if (newArray[3] == firstNumberByFive || newArray[3] == secondNumberByFive || newArray[3] == thirdNumberByFive || newArray[3] == fourthNumberByFive || newArray[3] == fifthNumberByFive || newArray[3] == sixthNumberByFive)
                            {
                                if (newArray[4] == firstNumberByFive || newArray[4] == secondNumberByFive || newArray[4] == thirdNumberByFive || newArray[4] == fourthNumberByFive || newArray[4] == fifthNumberByFive || newArray[4] == sixthNumberByFive)
                                {
                                    if (newArray[5] == firstNumberByFive || newArray[5] == secondNumberByFive || newArray[5] == thirdNumberByFive || newArray[5] == fourthNumberByFive || newArray[5] == fifthNumberByFive || newArray[5] == sixthNumberByFive)
                                    {
                                        if (firstNumber != firstNumberByFive && secondNumber != secondNumberByFive && thirdNumber != thirdNumberByFive && fourthNumber != fourthNumberByFive && fifthNumber != fifthNumberByFive && sixthNumber != sixthNumberByFive)
                                        {
                                            test.Add(num);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return test;
        }

        public List<int> MultiplyDigitsBySix(List<int> differentDigits)
        {
            int[] newArray = new int[6];
            List<int> test = new List<int>();
            for (int i = 0; i < differentDigits.Count; i++)
            {
                int num;
                Int32.TryParse(string.Join("", differentDigits[i]), out num);

                //Origin
                int firstNumber = num / 100000;
                int num1 = num % 100000;
                int secondNumber = num1 / 10000;
                int num2 = num1 % 10000;
                int thirdNumber = num2 / 1000;
                int num3 = num2 % 1000;
                int fourthNumber = num3 / 100;
                int num4 = num3 % 100;
                int fifthNumber = num4 / 10;
                int sixthNumber = num4 % 10;

                newArray[0] = firstNumber;
                newArray[1] = secondNumber;
                newArray[2] = thirdNumber;
                newArray[3] = fourthNumber;
                newArray[4] = fifthNumber;
                newArray[5] = sixthNumber;

                //MultiplyBySix
                int multiplyBySix = num * 6;
                int firstNumberBySix = multiplyBySix / 100000;
                int num1BySix = multiplyBySix % 100000;
                int secondNumberBySix = num1BySix / 10000;
                int num2BySix = num1BySix % 10000;
                int thirdNumberBySix = num2BySix / 1000;
                int num3BySix = num2BySix % 1000;
                int fourthNumberBySix = num3BySix / 100;
                int num4BySix = num3BySix % 100;
                int fifthNumberBySix = num4BySix / 10;
                int sixthNumberBySix = num4BySix % 10;

                if (newArray[0] == firstNumberBySix || newArray[0] == secondNumberBySix || newArray[0] == thirdNumberBySix || newArray[0] == fourthNumberBySix || newArray[0] == fifthNumberBySix || newArray[0] == sixthNumberBySix)
                {
                    if (newArray[1] == firstNumberBySix || newArray[1] == secondNumberBySix || newArray[1] == thirdNumberBySix || newArray[1] == fourthNumberBySix || newArray[1] == fifthNumberBySix || newArray[1] == sixthNumberBySix)
                    {
                        if (newArray[2] == firstNumberBySix || newArray[2] == secondNumberBySix || newArray[2] == thirdNumberBySix || newArray[2] == fourthNumberBySix || newArray[2] == fifthNumberBySix || newArray[2] == sixthNumberBySix)
                        {
                            if (newArray[3] == firstNumberBySix || newArray[3] == secondNumberBySix || newArray[3] == thirdNumberBySix || newArray[3] == fourthNumberBySix || newArray[3] == fifthNumberBySix || newArray[3] == sixthNumberBySix)
                            {
                                if (newArray[4] == firstNumberBySix || newArray[4] == secondNumberBySix || newArray[4] == thirdNumberBySix || newArray[4] == fourthNumberBySix || newArray[4] == fifthNumberBySix || newArray[4] == sixthNumberBySix)
                                {
                                    if (newArray[5] == firstNumberBySix || newArray[5] == secondNumberBySix || newArray[5] == thirdNumberBySix || newArray[5] == fourthNumberBySix || newArray[5] == fifthNumberBySix || newArray[5] == sixthNumberBySix)
                                    {
                                        if (firstNumber != firstNumberBySix && secondNumber != secondNumberBySix && thirdNumber != thirdNumberBySix && fourthNumber != fourthNumberBySix && fifthNumber != fifthNumberBySix && sixthNumber != sixthNumberBySix)
                                        {
                                            test.Add(num);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return test;
        }
    }
}
