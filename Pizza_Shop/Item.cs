using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Shop
{
    internal class Item
    {
        public const double AddPrice = 1.50;
        public const double DiscountLimit = 40.00;
        public string PizzaName { get; set; }
        public string Size { get; set; }
        public List<string> Adds { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public double Total { get; set; }

        public Item(Pizza pizza, string size, double sizePercentage, List<string> adds, int quantity)
        {
            PizzaName = pizza.Name;
            Size = size;
            Adds = adds;
            Quantity = quantity;

            CalculatePrice(pizza.Price, sizePercentage);
        }

        private void CalculatePrice(double basePrice, double sizePercentage)
        {
            Price = basePrice * sizePercentage + Adds.Count * AddPrice;
            double sum = Price * Quantity;

            if (sum > DiscountLimit)
            {
                sum *= 0.90;
            }
            Total = Math.Round(sum, 2);
        }

        public override string ToString()
        {
            string addsText = Adds.Count > 0 ? "(" + string.Join(", ", Adds) + ")" : "";
            return $"{PizzaName}, {Size}{addsText} x{Quantity} - {Total:F2} лв.";
        }

    }
}
