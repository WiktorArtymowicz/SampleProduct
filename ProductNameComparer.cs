using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SampleProduct
{
    public class ProductNameComparer : IComparer<Product>
    {
        public int Compare([AllowNull] Product x, [AllowNull] Product y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
