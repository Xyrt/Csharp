using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEra
{
    class Square
    {
        public int Lenght { get; set; }
        public static implicit operator Square(int i)
        {
            return new Square() { Lenght = i };
        }
        public static explicit operator Square(Rectongle r)
        {
            return new Square() { Lenght = r.Height };
        }
    }
}
