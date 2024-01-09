using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week__0
{
    internal class Laptop : Product
    {
        public Laptop(string name, float price) : base(name, price)
        {
        }

        public override void Report()
        {
            //Console.WriteLine("Hello from laptop");

            Console.WriteLine($"Product name: {Name}");
            Console.WriteLine($"Product price: {Price}");
        }
    }
}
