using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            string stand1 = new LemonadeStands();

            Console.WriteLine("What would you like to name your lemonade stand?");
            string nameOfStand = Console.ReadLine();

            Console.WriteLine("How many cups do you plan on selling?");
            string strInventory = Console.ReadLine();

            Console.WriteLine("How much does each cup of lemonade cost?");
            string strPricePerCup = Console.ReadLine();

            Console.WriteLine("How much does each cup cost for you to make? (cost of sugar, water, lemons, etc)?");
            string strCostOfProduction = Console.ReadLine();

            decimal Inventory = Int32.Parse(strInventory);
            decimal PricePerCup = Int32.Parse(strPricePerCup);
            decimal CostOfProduction = Int32.Parse(strCostOfProduction);
            decimal totalSpentOnSupplies = Inventory * CostOfProduction;
            decimal totalRevenue = Inventory * PricePerCup;
            decimal totalProfit = totalRevenue - totalSpentOnSupplies;
            
            Console.WriteLine($"{nameOfStand} brought in ${totalProfit} in profit, while spending ${totalSpentOnSupplies} on supplies and generated ${totalRevenue} in total revenue");
            
            Console.ReadLine();
        }
            
    }
}



    


