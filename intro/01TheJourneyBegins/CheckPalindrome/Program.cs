using System;

//Given the string, check if it is a palindrome.

namespace CheckPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution("232");
        }
        static bool Solution(string inputString)
        {
            string reverse = string.Join("", inputString.ToLower().Reverse());

            if (inputString == reverse)
            {
                Console.WriteLine($"{reverse} is a palindrome");

                return true;
            }
            else
            {
                Console.WriteLine($"{reverse} is not a palindrome");

                return false;
            }

        }


    }
}



