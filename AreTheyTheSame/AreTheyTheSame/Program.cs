using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AreTheyTheSame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a = new[] {121, 144, 19, 161, 19, 144, 19, 11};
            int[] b = new[] {121, 14641, 20736, 361, 25921, 361, 20736, 361};
            Console.WriteLine(ArraysSolution.AreTheSame(a, b));

            a = new[] {121, 144, 19, 161, 19, 144, 19, 11};
            b = new[] {132, 14641, 20736, 361, 25921, 361, 20736, 361};
            Console.WriteLine(ArraysSolution.AreTheSame(a,b));
            a = null;
            b = null;
            Console.WriteLine(ArraysSolution.AreTheSame(a,b));
        }
    }
    public class ArraysSolution {
        public static bool AreTheSame(int[] a, int[] b)
        {
            if (a == null || b == null) return false;
            var result = a.Select(x => x * x).OrderBy(x => x).SequenceEqual(b.OrderBy(x => x));
            return result;

        }
    }
}
