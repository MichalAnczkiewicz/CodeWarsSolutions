using System;
using System.Collections.Generic;
using System.Linq;

/*
    Write a function that takes an array and counts the number of each unique element present.
    Kata.Count(new List<string> {"James", "James", "John"}) =>
    new Dictionary<string, int> {{"James", 2}, {"John", 1}};

 */

namespace CountingArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Count(new List<string> { "James", "James", "John" }));
        }

        static Dictionary<string, int> Count(List<string> lst)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (var item in lst.GroupBy(i => i))
            {
                dictionary.Add(item.Key, item.Count());
            }

            return dictionary;
        }
    }
}
