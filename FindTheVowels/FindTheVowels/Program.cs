using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

/*
 We want to know the index of the vowels in a given word, for example, there are two vowels in the word super (the second and fourth letters).
 So given a string "super", we should return a list of [2, 4].

    Some examples:
    Mmmm  => []
    Super => [2,4]
    Apple => [1,5]
    YoMama -> [1,2,4,6]
 */

namespace FindTheVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine(VowelIndices("mmm"));
          //  Console.WriteLine(VowelIndices("SupEr"));
           // Console.WriteLine(VowelIndices("orange"));
            Console.WriteLine(VowelIndices("supercalifragilisticexpialidocious"));

        }

        public static int[] VowelIndices(string word)
        {
            var indexes = new List<int>();
            int position = -1;
            foreach (char c in word)
            {
                if ("aeiouyAEIOUY".Contains(c))
                {
                    position = word.IndexOf(c, position + 1);
                    indexes.Add(position +1 );
                }
            }

            Console.WriteLine("{0}  {1}", word, indexes.Count);
            return indexes.ToArray();
        }
    }
}
