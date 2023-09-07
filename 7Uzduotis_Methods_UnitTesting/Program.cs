using System;

namespace _7Uzduotis_Methods_UnitTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isValid = IsPasswordValid(input);
            Console.WriteLine(isValid);
        }
        public static bool IsPasswordValid(string password)
        {
            bool isLonger = password.Length > 8;
            return isLonger;
        }
    }
}