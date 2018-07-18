using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to name your lemonade stand?");
            string nameOfStand = Console.ReadLine();

            Console.WriteLine("How many cups do you plan on selling?");
            var Inventory = Console.ReadLine();

            Console.WriteLine("How much does each cup of lemonade cost?");
            var PricePerCup = Console.ReadLine();

            Console.WriteLine("How much does each cup cost for you to make? (cost of sugar, water, lemons, etc)?");
            var CostOfProduction = Console.ReadLine();





            Console.WriteLine($"You brought in {0} in profit, while spending {0} on supplies and generated {0} in total revenue");



            Console.ReadLine();
        }
            
    }
}



    


