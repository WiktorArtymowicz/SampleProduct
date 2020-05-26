using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProduct
{
    public class Supplier
    {
        private int? _id = null;
        private string _name = string.Empty;

        public Supplier(int? id, string name)
        {
            _id = id;
            _name = name;
        }

        public int? Id { get => _id; }
        public string Name { get => _name; }

        public static List<Supplier> GetSuppliers()
        {
            return new List<Supplier>()
            {
                new Supplier(id: 1, name: "Dostwca1"),
                new Supplier(id: 2, name: "Dostawca2")
            };
        }
    }
}
