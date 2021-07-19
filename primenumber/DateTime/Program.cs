using System;

namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int number = int.Parse(Console.ReadLine());
            var primenumber = new Primenumber();
            primenumber.Find(number);

        }
    }
}
