using System;

namespace SumOfSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(SumSequence(2,2,2));
            Console.WriteLine(SumSequence(2, 6, 2));
            Console.WriteLine(SumSequence(1, 5, 1));
        }

        static int SumSequence(int start, int end, int step)
        {
            var sum = 0;
            for (var i = start; i <= end; i+=step)
            {
                sum += i;
            }

            return sum;
        }
    }
}
