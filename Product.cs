using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProduct
{
    public class Product
    {
        private int? _id = 0;
        private string _name = string.Empty;
        private int? _price = 0;

        public int? Id { get => _id; }
        public string Name { get => _name; }
        public int? Price { get => _price; }


        public Product(int? id, string name, int? price)
        {
            _id = id;
            _name = name;
            _price = price;
        }

        public static List<Product> GetSampleList()
        {
            return new List<Product>()
            {
                new Product(id: 1, name: "Szawka", price: 30),
                new Product(id: 2, name: "Kuchenka", price: 80),
                new Product(id: 3, name: "Stolik", price: 60)
            };
        }

        public override string ToString()
        {
            return $"ID: {_id}, Name: {_name}, Price: {_price}";
        }

    }
}
