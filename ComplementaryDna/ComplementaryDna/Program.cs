using System;

/*
 * In DNA strings, symbols "A" and "T" are complements of each other, as "C" and "G".
 * You have function with one side of the DNA (string, except for Haskell); you need to get the other complementary side.
 * DNA strand is never empty or there is no DNA at all (again, except for Haskell).
 */

namespace ComplementaryDna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(MakeComplement("AAAA"));
            Console.WriteLine(MakeComplement("GGGG"));
            Console.WriteLine(MakeComplement("ATAT"));
            Console.WriteLine(MakeComplement("ATCG"));

        }

        public static string MakeComplement(string dna)
        {
            var dnaAsCharArray = dna.ToCharArray();
            var complementarySide = new char[dna.Length];
            for (int i = 0; i < dnaAsCharArray.Length; i++)
            {
                if (dnaAsCharArray[i] == 'A')
                    complementarySide[i] = 'T';
                else if (dnaAsCharArray[i] == 'T')
                    complementarySide[i] = 'A';
                else if (dnaAsCharArray[i] == 'G')
                    complementarySide[i] = 'C';
                else if (dnaAsCharArray[i] == 'C')
                    complementarySide[i] = 'G';
            }

            var stringComplementarySide = new string(complementarySide);
            return stringComplementarySide;
        }
    }
}
