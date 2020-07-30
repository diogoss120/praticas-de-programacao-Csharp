using AplicativoDeConsole.Entity;
using System;
using System.Collections.Generic;

namespace AplicativoDeConsole
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of products: ");
            int qtd = int.Parse(Console.ReadLine());
            List<Product> product = new List<Product>();
            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char p = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (p == 'c')
                {
                    product.Add(new Product(name, price));
                }
                else if (p == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    product.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double custom = double.Parse(Console.ReadLine());
                    product.Add(new ImportedProduct(name, price, custom));
                }
            }
            foreach (Product l in product)
            {
                Console.WriteLine(l.PriceTag());
            }
        }
    }
}