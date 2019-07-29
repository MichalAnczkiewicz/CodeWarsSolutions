using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace UniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int GetUnique(IEnumerable<int> numbers)
        {
            return numbers.GroupBy(x => x).Single(x => x.Count() == 1).Key;
        }
    }
}
