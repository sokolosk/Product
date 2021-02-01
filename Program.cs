using System;
using System.Collections.Generic;
using Product.Entities;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ComumProduct> list = new List<ComumProduct>();

            Console.Write("Enter the number of product: ");
            int n = int.Parse(Console.ReadLine());

            
            for(int i=1; i<n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)?");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (type == 'c')
                {
                    list.Add(new ComumProduct(name, price));
                }
                else if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFee));
                }

            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (ComumProduct prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
            


        }
    }
}
