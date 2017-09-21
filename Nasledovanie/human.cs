using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masledovanie
{
    public abstract class Human
    {
        public String Sex { get; set; }
        public Human(string sex)
        {
            Sex = sex;
            Console.WriteLine(sex);
            Console.WriteLine("Ya rodils9");
        }
        public virtual void SayHello()
        {
            Console.WriteLine("Net, ya nevospitan");
        }
        public abstract void Print();
    }
}
