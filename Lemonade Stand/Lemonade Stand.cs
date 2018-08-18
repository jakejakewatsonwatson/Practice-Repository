using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    public class Stand
    {
        public string nameOfStand { get; set; }
        public string strInventory { get; set; } 
        public decimal PricePerCup { get; set; }
        public string strCostOfProduction { get; set; }
        
        public decimal Inventory()
        {
            return decimal.Parse(strInventory);
        }

        public decimal CostOfProduction()
        {
            return Int32.Parse(strCostOfProduction);
        }

        public decimal TotalSpentOnSupplies()
        {
            return Inventory() * CostOfProduction();
        }

        public decimal TotalRevenue()
        {
            return Inventory() * PricePerCup;
        }

        public decimal TotalProfit()
        {
            return TotalRevenue() - TotalSpentOnSupplies();
        }
    }
}
