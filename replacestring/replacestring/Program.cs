using System;

namespace replacestring
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The string");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the word to be replaced");
            string word = Console.ReadLine();
            Console.WriteLine("Enter the word to replace");
            string replace = Console.ReadLine();
            str = str.Replace(word, replace);
            Console.WriteLine(str);
        }
    }
}
