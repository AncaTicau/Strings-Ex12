using System;

namespace Strings_Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenString = "maam";
            Console.WriteLine(IsPalindrome(givenString));
        }

        //Check if a string is palindrome (same value read from left to right and right to left) Ex: alabala -> True
        public static bool IsPalindrome(string input)
        {
            int length;

            if (input.Length % 2 == 0)
            {
                length = input.Length / 2;
            }
            else
            {
                length = (input.Length - 1) / 2;
            }

            for (int i = 0; i < length; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
