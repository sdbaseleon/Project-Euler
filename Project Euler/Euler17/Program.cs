using System;

namespace Euler17
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalWorth = 11;
            for (int i = 1; i < 1000; i++)
            {
                totalWorth += digitWorth(i.ToString());
            }

            Console.WriteLine(totalWorth.ToString());
        }

        private static int digitWorth(string num)
        {
            int worth = 0;
            for (int i = num.Length-1; i >= 0; i--)
            {
                if (i == num.Length-1)
                {
                    if (num[i] == '1')
                    {
                        worth += 3;
                    }
                    if (num[i] == '2')
                    {
                        worth += 3;
                    }
                    if (num[i] == '3')
                    {
                        worth += 5;
                    }
                    if (num[i] == '4')
                    {
                        worth += 4;
                    }
                    if (num[i] == '5')
                    {
                        worth += 4;
                    }
                    if (num[i] == '6')
                    {
                        worth += 3;
                    }
                    if (num[i] == '7')
                    {
                        worth += 5;
                    }
                    if (num[i] == '8')
                    {
                        worth += 5;
                    }
                    if (num[i] == '9')
                    {
                        worth += 4;
                    }
                }
                if(i == num.Length-2)
                {
                    if (num[i] == '1')
                    {
                        if (num[i + 1] == '0')
                        {
                            worth += 3;
                        }
                        if (num[i+1] == '1')
                        {
                            worth -= 3;
                            worth += 6;
                        }
                        if (num[i+1] == '2')
                        {
                            worth -= 3;
                            worth += 6;
                        }
                        if (num[i+1] == '3')
                        {
                            worth -= 5;
                            worth += 8;
                        }
                        if (num[i+1] == '4')
                        {
                            worth -= 4;
                            worth += 8;
                        }
                        if (num[i+1] == '5')
                        {
                            worth -= 4;
                            worth += 7;
                        }
                        if (num[i+1] == '6')
                        {
                            worth -= 3;
                            worth += 7;
                        }
                        if (num[i+1] == '7')
                        {
                            worth -= 5;
                            worth += 9;
                        }
                        if (num[i+1] == '8')
                        {
                            worth -= 5;
                            worth += 8;
                        }
                        if (num[i+1] == '9')
                        {
                            worth -= 4;
                            worth += 8;
                        }
                    }
                    if (num[i] == '2')
                    {
                        worth += 6;
                    }
                    if (num[i] == '3')
                    {
                        worth += 6;
                    }
                    if (num[i] == '4')
                    {
                        worth += 5;
                    }
                    if (num[i] == '5')
                    {
                        worth += 5;
                    }
                    if (num[i] == '6')
                    {
                        worth += 5;
                    }
                    if (num[i] == '7')
                    {
                        worth += 7;
                    }
                    if (num[i] == '8')
                    {
                        worth += 6;
                    }
                    if (num[i] == '9')
                    {
                        worth += 6;
                    }
                }
                if (i == num.Length - 3)
                {
                    if (num[i] == '1')
                    {
                        worth += 3;
                    }
                    if (num[i] == '2')
                    {
                        worth += 3;
                    }
                    if (num[i] == '3')
                    {
                        worth += 5;
                    }
                    if (num[i] == '4')
                    {
                        worth += 4;
                    }
                    if (num[i] == '5')
                    {
                        worth += 4;
                    }
                    if (num[i] == '6')
                    {
                        worth += 3;
                    }
                    if (num[i] == '7')
                    {
                        worth += 5;
                    }
                    if (num[i] == '8')
                    {
                        worth += 5;
                    }
                    if (num[i] == '9')
                    {
                        worth += 4;
                    }
                    worth += 10;
                }
            }
            return worth;
        }
    }
}
