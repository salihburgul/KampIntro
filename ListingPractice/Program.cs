using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListingPractice
{
    class Program
    {
        public static int Length { get; private set; }

        static void Main(string[] args)
        
        { 
            
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Description = "Fresh";
            product1.StockStatus = 15;
            product1.Price = 25;
            string[] product = new string[] { };
            Product product2 = new Product();
            product2.Name = "Melon";
            product2.Description = "Fresh";
            product2.StockStatus = 12;
            product2.Price = 30;
            Product[] products = new Product[] { product1, product2 };
            foreach (var Product in products)
            {
                Console.WriteLine(Product.Name);
                Console.WriteLine(Product.Description);
                Console.WriteLine(Product.StockStatus);
                Console.WriteLine(Product.Price);
            }
            
        
        }
    }
}      