using System;
using System.Collections.Generic;
using System.Linq;

/*
  Make a program that filters a list of strings and returns a list with only your friends name in it.
  If a name has exactly 4 letters in it, you can be sure that it has to be a friend of yours! 
  Otherwise, you can be sure he's not...
  Ex: Input = ["Ryan", "Kieran", "Jason", "Yous"], Output = ["Ryan", "Yous"]
*/

namespace FriendOrFoe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(FriendOrFoe(new[] { "Ryan", "Kieran", "Mark", "Jimmy" }));
            Console.WriteLine(FriendOrFoe(new []{"Peter", "Anna", "Michael"}));
        }

        /*
         * Only 4 names which have letters are your friends;
         */
        static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return names?.Where(x => x.Length == 4);
        }

    }
}
