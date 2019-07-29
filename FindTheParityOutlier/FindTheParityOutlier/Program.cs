using System;
using System.Collections.Generic;
using System.Linq;

/*
 You are given an array (which will have a length of at least 3, but could be very large) containing integers. 
 The array is either entirely comprised of odd integers or entirely comprised of even integers except for a single integer N. 
 Write a method that takes the array as an argument and returns this "outlier"
 */

namespace FindTheParityOutlier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Find(new int [] { 2, 6, 8, -10, 3}));
        }

        public static int Find(int[] integers)
        {
            var oddNumbersList = new List<int>();
            var evenNumbersList = new List<int>();

            foreach (int number in integers)
            {

                if (number % 2 != 0)
                {
                    oddNumbersList.Add(number);
                }
                else
                {
                    evenNumbersList.Add(number);
                }

            }

            return oddNumbersList.Count == 1 ? oddNumbersList.First() : evenNumbersList.First();
        }
    }
}
