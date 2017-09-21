using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masledovanie
{
    public class Teacher : Human
    {
        public Teacher() : base("KY KY")
        {
            Console.WriteLine("Seichas budet bolno");
        }
        public override void Print()
        {
            throw new NotImplementedException();
        }
        public override void SayHello()
        {
            Console.WriteLine("Zdarova lodir");
        }
    }
}
