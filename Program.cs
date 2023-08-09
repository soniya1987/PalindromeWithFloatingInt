using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeWithFloatingInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = 10.01;
            Console.WriteLine(string.Format("the number {0} is{1}a Palindrome", number, (IsPalindrome(number) ? " " : " not ")));
            number = 10.012;
            Console.WriteLine(string.Format("the number {0} is{1}a Palindrome", number, (IsPalindrome(number) ? " " : " not ")));
            number = 1001;
            Console.WriteLine(string.Format("the number {0} is{1}a Palindrome", number, (IsPalindrome(number) ? " " : " not ")));
            number = -1001;
            Console.WriteLine(string.Format("the number {0} is{1}a Palindrome", number, (IsPalindrome(number) ? " " : " not ")));
            Console.Read();
        }

        static bool IsPalindrome(double num)
        {
            string actual = num.ToString().Replace("-", "");
            for (int i = actual.Length - 1; i >= actual.Length / 2; i--)
            {
                //Console.WriteLine("The Character is " + actual[i] + ", " + actual[(actual.Length - i) - 1]);
                if (actual[i] != actual[(actual.Length - i) - 1])
                    return false;
                else
                    continue;
            }
            return true;
        }
    }
}
