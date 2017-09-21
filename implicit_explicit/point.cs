using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace NewEra
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point() { }
       
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
 
        public static Point operator++(Point p)
        {
            p.X++;
            p.Y++;
            return p;
        }
 
        public static Point operator --(Point p)
        {
            p.X--;
            p.Y--;
            return p;
        }
 
        public static Point operator -(Point p)
        {
            return new Point() { X = -p.X, Y = -p.Y};
        }
 
        public override string ToString()
        {
            return $"X = {X}, Y = {Y}";
        }
        public static bool operator true(Point p)
        {
            return !(p.X == 0 && p.Y == 0);
        }
        public static bool operator false(Point p)
        {
            return (p.X == 0 && p.Y == 0);
        }
        public static Point operator |(Point p1, Point p2)
        {
            if (p1.X != 0 || p1.Y != 0 || p2.X != 0 || p2.Y != 0)
                return p2;
            else
                return new Point();
        }
    }
}
 
