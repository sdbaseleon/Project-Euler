using System;

namespace Euler21
{
    class Program
    {
        static void Main(string[] args)
        {
            int word = 0;
            for (int i = 1; i < 10000; i++)
            {
                int divisorAddition = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        divisorAddition += j;
                    }
                }
                int amicableDivisors = 0;
                for (int j = 1; j < divisorAddition; j++)
                {
                    if (divisorAddition % j == 0)
                    {
                        amicableDivisors += j;
                    }
                }
                if (i == amicableDivisors && i != divisorAddition)
                {
                    word += i;
                }
            }
            Console.Write(word.ToString());
        }
    }
}
