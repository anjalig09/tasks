using System;

namespace palindromenumber
{
    public class Palindrome
    {
        public int remainder, i, sum = 0;
        public void Calc(int num)
        {
            int temp = num;
            while (num!=10)
            {
                remainder = num % 10;
                sum = (sum * 10) + remainder;
                num = num / 10;
            }
            if (temp == num)
            {
                Console.WriteLine("Number is palindrome");
            }
            else
            {
                Console.WriteLine("Number is not palindrome");
            }
        }
        
    }
}
