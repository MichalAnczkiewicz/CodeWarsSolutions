using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace TheCouponCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(CheckCoupon("123", "123", "September 5, 2014", "October 1, 2014"));
            Console.WriteLine(CheckCoupon("123a", "123", "September 5, 2014", "October 1, 2014"));
        }

        public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate,
            string expirationDate)
        {

            return enteredCode == correctCode && DateTime.Parse(currentDate) <= DateTime.Parse(expirationDate);
        }
    }
}
