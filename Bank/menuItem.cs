using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class MenuItem
    {
        public string Title { get; set; }
        public MenuItem(string title)
        {
            Title = title;
        }
        public virtual void Select(MenuItem prev)
        {
            Console.Clear();
        }
    }
}
