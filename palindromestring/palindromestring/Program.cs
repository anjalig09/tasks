using System;

namespace palindromestring
{
    class Program
    {
        static void Main(string[] args)
        {
            string reverse="";
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            for(int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }
            if (str == reverse)
            {
                Console.WriteLine("Given string is palindrome");
            }
            else
            {
                Console.WriteLine("Given string is not Palindrome");
            }
                  

        }
    }
}
