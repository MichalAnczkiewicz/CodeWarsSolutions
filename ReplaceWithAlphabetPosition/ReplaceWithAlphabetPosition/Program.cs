using System;
using System.ComponentModel.DataAnnotations;

namespace ReplaceWithAlphabetPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(AlphabetPosition("The sunset sets at twelve o' clock."));
        }

        static string AlphabetPosition(string text)
        {
            string output = "";
            int index = 0;
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    index += char.ToUpper(c) - 64;
                    output += index + " ";
                    index = 0;
                }
            }

            return output.TrimEnd();
        }
    }
}
