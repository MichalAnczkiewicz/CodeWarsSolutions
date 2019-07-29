using System;

namespace SortStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SortByLength(new string[] { "I", "To", "Beg", "Life"});
            SortByLength(new string[] { "", "Pizza", "Brains", "Moderately" });
        }

        static string[] SortByLength(string[] array)
        {
            string temp = "";

            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].Length > array[j + 1].Length)
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }
    }
}
