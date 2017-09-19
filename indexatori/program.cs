using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexatori
{
    class Program
    {

        static void Main(string[] args)
        {
            var shop = new Shop();
            shop.AddLaptop(new Laptop() { Brand = "DELL", Price = 1500 });
            Console.WriteLine(shop[1]?.Brand);
            Console.WriteLine(shop["Tajik Company"]);
            foreach(var laptop in shop["DELL"])
            {
                Console.WriteLine("Brand {0}, Price {1}", laptop.Brand, laptop.Price);
            }
        }
    }
}
