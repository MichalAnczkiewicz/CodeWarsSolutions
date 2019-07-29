using System;
/*
 * Complete the function power_of_two/powerOfTwo (or equivalent, depending on your language) that determines if a given non-negative integer is a power of two.
 */
namespace IsPowerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(PowerOfTwo(2));
            Console.WriteLine(PowerOfTwo(3));
            Console.WriteLine(PowerOfTwo(1));
            Console.WriteLine(PowerOfTwo(0));


        }

        public static bool PowerOfTwo(int n)
        {
            return (n != 0) && ((n & (n - 1)) == 0);
        }
    }
}
