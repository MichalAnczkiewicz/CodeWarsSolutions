using System;

namespace StringEndsWith
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Solution("samurai", "ai"));
            Console.WriteLine(Solution("sumo", "omo"));
            Console.WriteLine(Solution("samurai", "ra"));
            Console.WriteLine(Solution("abc", "abcd"));

        }

        public static bool Solution(string str, string ending)
        {
            return str.EndsWith(ending);
        }
    }
}
