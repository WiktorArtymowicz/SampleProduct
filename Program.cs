using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = Product.GetSampleList();
            products.Sort(new ProductNameComparer());

            foreach (var item in products)
            {
                Console.WriteLine(item.ToString());
            }

            products.Sort(delegate (Product x, Product y) 
            { 
                return x.Price.HasValue.CompareTo(y.Price.HasValue); 
            });

            Console.WriteLine();

            foreach (var item in products)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine();

            products.Sort((x, y) => x.Id.HasValue.CompareTo(y.Id.HasValue)); //To jest to samo co delegat wyżej, jednak tutaj jest wyrażenie lambda

            foreach (var item in products)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine();

            foreach (var item in products.Where(p => p.Price > 35))
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
