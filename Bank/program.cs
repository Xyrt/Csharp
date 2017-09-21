using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new MenuItemCollection(null, new MenuItem[]
            {
                new MenuItemCollection("Balance", new MenuItem[]
                {
                    new MenuItem("Display"),
                    new MenuItem("Chek")
                }),
                new MenuItemCollection("WithDrow", new MenuItem[]
                {
                    new MenuItem("BYN"),
                    new MenuItem("USD")
                })
            });
            menu.Select(null);
        }
    }
}
