using System;

namespace palindromenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());

            var palindrome = new Palindrome();
            palindrome.Calc(number);
        }
    }
}
