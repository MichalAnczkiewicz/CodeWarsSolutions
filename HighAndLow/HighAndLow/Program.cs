using System;
using System.Collections.Generic;
using System.Linq;

namespace HighAndLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(HighAndLowV2("1 2 3 4 5"));
            Console.WriteLine(HighAndLowV2("1 9 3 4 -5"));
        }

        public static string HighAndLow(string numbers)
        {
            var stringArray = numbers.Split(" ");
            var numbersList = new List<int>();
            foreach (var item in stringArray)
            {
                numbersList.Add(Int32.Parse((item)));
            }

            numbersList.Sort();
            var returnString = numbersList.Max().ToString();
            returnString += " " + numbersList.Min().ToString();
            return returnString;
        }

        public static string HighAndLowV2(string numbers)
        {
            int[] myInts = numbers.Split(" ").Select(n => Convert.ToInt32(n)).ToArray();
            return myInts.Max() + " " + myInts.Min(); ;
        }
    }
}
