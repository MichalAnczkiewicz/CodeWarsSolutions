using System;
using System.Globalization;
using System.Linq;
/*
 * Complete the method/function so that it converts dash/underscore delimited words into camel casing.
 * The first word within the output should be capitalized only if the original word was capitalized
 * (known as Upper Camel Case, also often referred to as Pascal case). 
 */

namespace ConvertToCamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(ToCamelCase("the_stealth_warrior"));
            Console.WriteLine(ToCamelCase("The-Stealth-Warrior"));
        }

        static string ToCamelCase(string str)
        {
            var input = str.Split('_', '-');
            var stringToReturn = "";
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

            if (input[0].Any(char.IsLower))
                stringToReturn += input[0];
            else
                stringToReturn += input[0].ToUpper();

            for (var i = 1; i < input.Length; i++)
            {
                stringToReturn += myTI.ToTitleCase(input[i]);
            }


            return stringToReturn;
        }
    }
}
