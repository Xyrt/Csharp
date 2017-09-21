using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masledovanie
{
    public class Student : Human
    {
        public Student() : base("Nachalo proccesa")
        {
            Console.WriteLine("Ya prokachals9");
        }
        public override void Print()
        {
            throw new NotImplementedException();
        }
        public override void SayHello()
        {
            Console.WriteLine("Ya ne ob9zan s vami zdorovats9");
        }
    }
}
