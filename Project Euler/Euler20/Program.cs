using System;
using System.Numerics;

namespace Euler20
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger nFactorial = 1;
            for (long i = 100; i >= 1; i--)
            {
                nFactorial *= i;
            }
            String factorialString = nFactorial.ToString();
            int sumOfString = 0;
            for(int i = 0; i < factorialString.Length; i++)
            {
                sumOfString += Int32.Parse(factorialString[i].ToString());
            }
            Console.Write(sumOfString);
        }
    }
}
