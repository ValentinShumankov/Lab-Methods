using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            PriceCalculator(Console.ReadLine(), double.Parse(Console.ReadLine()));
        }
       
        /// <summary>
        /// Calculates price per cuantity.
        /// </summary>
        /// <param name="product">Name of product</param>
        /// <param name="count">Count of products</param>
        static void PriceCalculator ( string product, double count)
        {
            switch (product)
            {
                case "coffee":
                    Console.WriteLine($"{count * 1.50:f2}");
                    break;
                case "water":
                    Console.WriteLine($"{count * 1.00:f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{count * 1.40:f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{count * 2.00:f2}");
                    break;
                default:
                    break;
            }
        }
   
    }
}
