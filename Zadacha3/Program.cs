using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumOfPrimeNums = 0;
            int sumOfNonPrimeNums = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "stop")
                {
                    break;
                }

                int number = int.Parse(command);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }

                bool itsPrime = true;

                if (number > 1)
                {
                    for (int i = 2; i * i <= number; i++)
                    {
                        if (number % i == 0)
                        {
                            itsPrime = false;
                            break;
                        }
                    }
                }

                if (itsPrime)
                {
                    sumOfPrimeNums += number;
                }
                else
                {
                    sumOfNonPrimeNums += number;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumOfPrimeNums}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumOfNonPrimeNums}");
        }
    }
}
