using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEra
{
    class Fraction
    {
        public int Numerator { get; set; }
        public int Denomenator { get; set; }

        public Fraction(int num, int den)
        {
            if (den == 0)
            {
                throw new ArgumentException("Ne mogy, sori");
            }
            Numerator = num;
            Denomenator = den;
        }
        public static Fraction operator * (Fraction f, int i)
        {
            return new Fraction(f.Numerator * i, f.Denomenator);
        }
        public static Fraction operator * (int i, Fraction f)
        {
            return f * i;
        }
        public static implicit operator Fraction(double d)
        {
            return new Fraction((int) d * 1000, 1000);
        }
        public static Fraction operator + (Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numerator + f2.Denomenator + f2.Numerator + f1.Denomenator, f1.Denomenator * f2.Denomenator);
        }
    }
}
