using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(TwoSum(new[] { 1, 2, 3 }, 4));
            Console.WriteLine(TwoSum(new[] { 1234, 5678, 9012 }, 14690));
            Console.WriteLine(TwoSum(new[] { 2, 2, 3 }, 4));
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            for (int j = i + 1; j < numbers.Length; j++)
                if (numbers[i] + numbers[j] == target)
                    return new int[] { i, j };

            return new int[0];
        }
    }
}
