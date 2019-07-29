using System;
/*
 * Create a function that returns the sum of the two lowest positive numbers given an array of minimum 4 positive integers.
 * No floats or non-positive integers will be passed.
 * For example, when an array is passed like [19, 5, 42, 2, 77], the output should be 7.
 */

namespace SumOfTwoLowestPositiveIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(sumTwoSmallestNumbers(new int [] { 19, 5, 42, 2, 77 }));
        }

        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            var minimum = int.MaxValue;
            var secondMinimum = int.MaxValue;
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minimum)
                {
                    secondMinimum = minimum;
                    minimum = numbers[i];
                }
                else if(numbers[i] < secondMinimum && numbers[i] != minimum)
                {
                    secondMinimum = numbers[i];
                }
            }

            return minimum + secondMinimum;
        }
    }
}
