using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                bool itsSpecial = true;
                int number = i;

                while (number > 0)
                {
                    int digitDiv = number % 10;

                    if (n % digitDiv != 0)
                    {
                        itsSpecial = false;
                        break;
                    }

                    number /= 10;
                }

                if (itsSpecial)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
