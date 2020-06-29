using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(checkPalindrome("a@b!!b$a", "!@$"));
            Console.WriteLine(checkPalindrome("?Aa#c", "#?"));
        }
        public static bool checkPalindrome(string inputString, string trashSymbolString)
        {
            int length = inputString.Length;
            for (int i = 0, j = length - 1; i < length; i++, j--)
            {
                while (trashSymbolString.Contains(inputString[i])) i++;
                while (trashSymbolString.Contains(inputString[j])) j--;
                if (inputString[i].CompareTo(inputString[j])!=0) return false;
            }

            return true;
        }

    }
}
