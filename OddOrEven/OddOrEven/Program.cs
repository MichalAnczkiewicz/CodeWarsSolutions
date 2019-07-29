using System;
using System.Linq;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(OddOrEven(new int[] { 0, 1, 5}));
            Console.WriteLine(OddOrEven(new int[] { 0, -1, -5 }));
            Console.WriteLine(OddOrEven(new int[] { 0, 1, 2 }));
            Console.WriteLine(OddOrEven(new int[] { 0}));
            Console.WriteLine(OddOrEven(new int[] { 1 }));
            Console.WriteLine(OddOrEven(new int[] { 0 }));



        }

        public static string OddOrEven(int[] array)
        {
            return array.Sum() % 2 == 0 ? "Even" : "Odd";
        }
    }
}
