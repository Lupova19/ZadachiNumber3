using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int allTickets = 0;
            int studentTickets = 0;
            int standardTickets = 0;
            int kidsTickets = 0;

            string command;
            while ((command = Console.ReadLine()) != "Finish")
            {
                string movieName = command;
                int capacityOfTheHall = int.Parse(Console.ReadLine());
                int soldStudentTickets = 0;
                int soldStandardTickets = 0;
                int soldKidsTickets = 0;

                string typeOfTicket;
                while ((typeOfTicket = Console.ReadLine()) != "End")
                {
                    switch (typeOfTicket)
                    {
                        case "student":
                            soldStudentTickets++;
                            break;
                        case "standard":
                            soldStandardTickets++;
                            break;
                        case "kid":
                            soldKidsTickets++;
                            break;
                    }
                }

                int soldTickets = soldStudentTickets + soldStandardTickets + soldKidsTickets;
                allTickets += soldTickets;
                studentTickets += soldStudentTickets;
                standardTickets += soldStandardTickets;
                kidsTickets += soldKidsTickets;

                double occupancyRate = (double)soldTickets / capacityOfTheHall * 100;
                Console.WriteLine($"{movieName} - {occupancyRate}% full.");
            }

            Console.WriteLine($"Total tickets: {allTickets}");
            Console.WriteLine($"{((double)studentTickets / allTickets) * 100}% student tickets.");
            Console.WriteLine($"{((double)standardTickets / allTickets) * 100}% standard tickets.");
            Console.WriteLine($"{((double)kidsTickets / allTickets) * 100}% kids tickets.");
        }
    }
    
}

