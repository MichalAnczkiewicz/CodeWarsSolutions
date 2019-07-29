using System;
using System.Linq;
/*
  Given an array, find the int that appears an odd number of times.
  There will always be only one integer that appears an odd number of times.

 */
namespace FindTheOddInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(FindIntWhichAppearsOddNumberOfTimes(new[]
                {20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5}));
            Console.WriteLine(FindIntWhichAppearsOddNumberOfTimes(new[]
                {4,4,4}));
            Console.WriteLine(FindIntWhichAppearsOddNumberOfTimes(new[]
                {4,4,3,4,3,3,4}));
        }

        public static int FindIntWhichAppearsOddNumberOfTimes(int[] numbers)
        {

            return numbers.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
        }
    }
}
