using System;
using System.Collections.Generic;
/*
 The new "Avengers" movie has just been released! There are a lot of people at the cinema box office standing in a huge line. 
 Each of them has a single 100, 50 or 25 dollars bill. An "Avengers" ticket costs 25 dollars.
 Vasya is currently working as a clerk. He wants to sell a ticket to every single person in this line.
 Can Vasya sell a ticket to each person and give the change if he initially has no money and sells the tickets strictly in the order people follow in the line?
 Return YES, if Vasya can sell a ticket to each person and give the change with the bills he has at hand at that moment. Otherwise return NO.
    
    Examples:
    Line.Tickets(new int[] {25, 25, 50}) // => YES 
    Line.Tickets(new int[] {25, 100}) // => NO. Vasya will not have enough money to give change to 100 dollars
    Line.Tickets(new int[] {25, 25, 50, 50, 100}) // => NO. Vasya will not have the right bills to give
*/
namespace Vasya_Clerk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Tickets(new int[] { 25, 25, 50 })); //YES
            Console.WriteLine(Tickets(new int[] { 25, 100 })); //NO
            Console.WriteLine(Tickets(new int[] { 25, 25, 50, 50, 100 })); //NO
            Console.WriteLine(Tickets(new int[] { 25, 25, 25, 25, 50, 100, 50 })); //YES
            Console.WriteLine(Tickets(new int[] { 25, 25, 25, 25, 25, 100, 100 })); // NO

        }
        private static readonly int TICKETPRICE = 25;
        private static readonly string [] Bills = {"25BILL", "50BILL", "100BILL"};

        static string Tickets(int[] peopleInLine)
        {


            var moneyVasyaHas = 0;
            var storedMoney = new Dictionary<string, int>();
            storedMoney.Add(Bills[0], 0);
            storedMoney.Add(Bills[1], 0);
            storedMoney.Add(Bills[2],0);

            for (var i = 0; i < peopleInLine.Length; i++)
            {
                if (peopleInLine[i] == 25)
                {
                    moneyVasyaHas += 25;
                    storedMoney[Bills[0]] += 1;
                }

                if (peopleInLine[i] == 50)
                {
                    if (peopleInLine[i] - TICKETPRICE < moneyVasyaHas)
                    {
                        if (storedMoney[Bills[0]] < 0)
                        {
                            return "NO";
                        }
                        moneyVasyaHas += 25;
                        storedMoney[Bills[1]] += 1;
                        storedMoney[Bills[0]] -= 1;
                       
                    }
                    else
                    {
                        return "NO";
                    }
                }

                if (peopleInLine[i] == 100)
                {
                    if (peopleInLine[i] - TICKETPRICE < moneyVasyaHas)
                    {
                        if ((storedMoney[Bills[0]] < 1 && storedMoney[Bills[1]] < 1) || storedMoney[Bills[0]] <= 2)
                        {
                            return "NO";
                        }

                        if (storedMoney[Bills[1]] == 0)
                        {
                            storedMoney[Bills[0]] -= 3;
                            storedMoney[Bills[2]] += 1;
                            moneyVasyaHas += 25;
                        }
                        else
                        {
                            storedMoney[Bills[0]] -= 1;
                            storedMoney[Bills[1]] -= 1;
                            storedMoney[Bills[2]] += 1;
                            moneyVasyaHas += 25;
                        }
                        
                       
                    }
                    else
                    {
                        return "NO";
                    }
                }

            }
            return "YES";
        }
    }
}
