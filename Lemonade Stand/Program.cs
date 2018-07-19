using System;
using System.Collections.Generic;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Stand> stands = new List<Stand>();

            Console.WriteLine("How many lemonade stands would you like to open this summer?");
            string strNumberOfStands = Console.ReadLine();
            decimal numberOfStands = Int32.Parse(strNumberOfStands);

            for (int i = 0; i < numberOfStands; i++)
            {
                Stand stand = new Stand();
                
                Console.WriteLine("What would you like to name this lemonade stand?");
                stand.nameOfStand = Console.ReadLine();
                stands.Add(stand);

                Console.WriteLine("How many cups do you plan on selling at this location?");
                stand.strInventory = Console.ReadLine();

                Console.WriteLine("How much does each cup of lemonade cost at this location?");
                stand.strPricePerCup = Console.ReadLine();

                Console.WriteLine("How much does each cup cost for you to make? (cost of sugar, water, lemons, etc)?");
                stand.strCostOfProduction = Console.ReadLine();
                
                //Console.WriteLine($"{stand.nameOfStand} brought in ${stand.TotalProfit()} in profit, while spending ${stand.TotalSpentOnSupplies()} on supplies and generated ${stand.TotalRevenue()} in total revenue");
                
            }

            Console.ReadLine();
            foreach (Stand stand in stands)
            {
                Console.WriteLine($"{stand.nameOfStand} brought in ${stand.TotalProfit()} in profit, while spending ${stand.TotalSpentOnSupplies()} on supplies and generated ${stand.TotalRevenue()} in total revenue");
            }

            Console.ReadLine();
        }
            
    }
}



    


