using System;
/*
 Your task is to write a function which returns the sum of following series upto nth term(parameter).
 Series: 1 + 1/4 + 1/7 + 1/10 + 1/13 + 1/16 +...
 Rules:
 You need to round the answer to 2 decimal places and return it as String.
 If the given value is 0 then it should return 0.00
 You will only be given Natural Numbers as arguments.

 */
namespace Sum_of_the_first_nth_term_of_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SeriesSum(5));
        }
        public static string SeriesSum(int n)
        {
            var sum = 0.00M;
            var counter = 1.00M;
            var denominator = 1.00M;

            for (var i = 0; i < n; i++)
            {
                sum += counter / denominator;
                denominator += 3;
            }

            return Math.Round(sum, 2).ToString("0.00").Replace(",", ".");
        }
    }
}
