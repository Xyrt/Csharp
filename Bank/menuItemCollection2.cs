using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class MenuItemCollection : MenuItem
    {
        private MenuItem[] items;
        public MenuItemCollection(string title, MenuItem[] items) : base(title)
        {
            this.items = items;
        }

        public override void Select(MenuItem prev)
        {
            base.Select(prev);
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("{0} {1}", i + 1 , items[i].Title);
            }
            var input = Console.ReadLine();
            int index = int.Parse(input);
            if (index == 0)
            {
                if (prev != null)
                {
                    prev.Select(this);
                }
            }
            else
            {
                items[index - 1].Select(this);
            }
        }
    
    }
}
    
