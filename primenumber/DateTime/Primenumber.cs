using System;

namespace DateTime
{
    public class Primenumber
    {
        public int i, m = 0;
        public void Find(int num)
        {

            if (num == 1)
            {
                Console.WriteLine("Number is neither prime nor composite");
                
            }
            m = num / 2;
            for (i = 2; i < m; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Number is not prime");
                    break;
                }

            }
            Console.WriteLine("Number is prime");
        }

    }
}
