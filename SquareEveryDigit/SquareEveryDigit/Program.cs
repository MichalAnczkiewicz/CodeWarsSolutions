using System;

namespace SquareEveryDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(calculateSquare(9119));
            Console.WriteLine(calculateSquare(121));
        }

        static int calculateSquare(int n)
        {
            string output = "";
            foreach (var c in n.ToString())
            {
                int square = int.Parse(c.ToString());
                output += (square * square);
            }

            return int.Parse(output);
        }
    }
}
