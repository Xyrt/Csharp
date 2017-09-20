using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Min(1, 10);

            var p = new Point() { X = 10, Y = 15 };
            Console.WriteLine($"p++: {p++}");
            Console.WriteLine($"++p: {++p}");
            Console.WriteLine($"p--: {p--}");
            Console.WriteLine($" -p: {-p}");
            var p2 = new Point() { X = 5, Y = -5 };
            var v = new Vector(p, p2);
            var v2 = new Vector(new Point(0, 0), new Point(-5, -5));
            var p3 = new Point(1, 1);
            var p4 = new Point(1, 1);
            Console.WriteLine(p3.Equals(p4));
            Console.WriteLine(ReferenceEquals(p3, p4));
            var p5 = new Spoint(1, 1);
            var p6 = new Spoint(1, 1);
            Console.WriteLine(p5.Equals(p6));
            Console.WriteLine(ReferenceEquals(p5, p6));
        }
    }
}
