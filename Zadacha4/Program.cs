using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryCounter = int.Parse(Console.ReadLine());
            double wholeScore = 0;
            int presentationsCounter = 0;

            while (true)
            {
                string presentationName = Console.ReadLine();

                if (presentationName == "Finish")
                {
                    break;
                }

                double presentationScore = 0;

                for (int i = 0; i < juryCounter; i++)
                {
                    presentationScore += double.Parse(Console.ReadLine());
                }

                wholeScore += presentationScore;
                presentationsCounter++;

                Console.WriteLine($"{presentationName} - {presentationScore / juryCounter}.");
            }
            Console.WriteLine($"Students final assessment is {wholeScore / presentationsCounter}.");
        }
    }
}
