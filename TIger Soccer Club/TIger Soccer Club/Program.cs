using System;
using System.Collections.Generic;

namespace TigerSoccerClub
{
    class Program
    {

        static double SumTotals(List<double> totals)
        {
            double sum = 0;
            foreach (double t in totals)
                sum += t;

            return sum;
        }
        static void Main(string[] args)
        {
            int i = 0;
            double total = 0;

            String Name = "";
            String Registration = "";
            String Jersey = "";

            // CHANGE #3: store players for summary
            List<PlayerData> players = new List<PlayerData>();
            List<double> totals = new List<double>();

            //these lines of codes are for aligning items to center and contains heading portion
            string s = "*****Welcome to TigerSoccerClub*****";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);

            Console.Write("Enter the number of players per registrations: ");
            int Players = Convert.ToInt32(Console.ReadLine());

            if (Players > 4 || Players < 1)
            {
                Console.WriteLine("Invalid number, Please enter the registration number betweeen 1 to 4");
            }
            else
            {
                // CHANGE #3: One loop for ALL players instead separate into 2 scenarios
                for (i = 0; i < Players; i++)
                {
                    Console.Write("Enter name: ");
                    Name = Console.ReadLine();

                    // Change #4 – validated inputs
                    Registration = InputValidation.GetValidRegistration();
                    Jersey = InputValidation.GetValidJersey();

                    // CHANGE #1: Create PlayerData object
                    PlayerData pdata = new PlayerData(Name, Registration, Jersey);
                    players.Add(pdata);

                    // CHANGE #2: Use PriceCalculator (discount only if more than 1 player)
                    bool applyDiscount = (Players > 1);
                    total = PriceCalculator.Calculate(Registration, Jersey, applyDiscount);
                    totals.Add(total);

                    Console.WriteLine("Total price from " + Name + " is: " + total);
                    Console.WriteLine();
                }
                // Change #5 - Final Summary
                double grandTotal = SumTotals(totals);
                Console.WriteLine("Grand Total of All Orders: " + grandTotal);
                Console.WriteLine();

                // Change #6 (Biweekly Task 6 #1) - Detailed summary table for all players
                Console.WriteLine("Summary of Registrations");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Name\t\tType\tJersey\tTotal");
                Console.WriteLine("------------------------------------------------------");

                for (int idx = 0; idx < players.Count; idx++)
                {
                    PlayerData p = players[idx];
                    double playerTotal = totals[idx];
                    Console.WriteLine($"{p.Name}\t{p.Registration}\t{p.Jersey}\t{playerTotal}");
                }

                Console.WriteLine("------------------------------------------------------");

                // This is for Github Task
                // CHANGE #7 (Biweekly Task 6 #2) – Total BEFORE discount + Discount Saved
                double beforeDiscount = 0;

                foreach (var p in players)
                {
                    // Calculate WITHOUT any discount
                    beforeDiscount += PriceCalculator.Calculate(p.Registration, p.Jersey, false);
                }

                double discountSaved = beforeDiscount - grandTotal;

                Console.WriteLine("Total before discount: " + beforeDiscount);
                Console.WriteLine("Total discount saved: " + discountSaved);
                Console.WriteLine();
            }
        }
    }
}
