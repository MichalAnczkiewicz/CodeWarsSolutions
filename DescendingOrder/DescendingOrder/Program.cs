using System;
using System.Linq;

/*
 * Your task is to make a function that can take any non-negative integer as a argument
 * and return it with its digits in descending order.
 * Essentially, rearrange the digits to create the highest possible number.
    Examples:
    Input: 21445 Output: 54421
 */

namespace DescendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Before: 12345" + " after: " + DescendingOrder(12345));

            Console.WriteLine("Before: 893724769" + " after: " + DescendingOrder(893724769));
            Console.WriteLine("Before: 0" + " after: " + DescendingOrder(0));
        }
        public static int DescendingOrder(int number)
        {
            var descendingNumberString = string.Join("", number.ToString().ToCharArray().OrderByDescending(x => x));
            var descendingNumber = Int32.Parse(descendingNumberString);

            return descendingNumber;

        }
    }
}
