using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week__0
{
    internal abstract class Product
    {
        public string Name;
        public float Price;

        public Product(string name, float price)
        {
            this.Name = name;
            this.Price = price;
        }

        public abstract void Report();
    }
}
