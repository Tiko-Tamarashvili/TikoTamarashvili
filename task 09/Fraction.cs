using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    public class Fraction
    {
        public Fraction(int numerator, int denumerator)
        {
            if (denumerator == 0)
            {
                throw new ArgumentException("0 ze gayofa sheudzlebelia");
            }
                
            _numerator = numerator;
            _denumerator = denumerator;

        }

        private int _numerator  { get; set; }
        private int _denumerator { get; set; }


        public override string ToString()
        {
            return _numerator + "/" + _denumerator;
        }


        public static Fraction operator +(Fraction a, Fraction b)
        {
            int commonDenumerator = a._denumerator * b._denumerator;
            int newNumerator = a._numerator * b._denumerator + b._numerator * a._denumerator;
            return new Fraction(newNumerator, commonDenumerator);
        }


        public static bool operator ==(Fraction a, Fraction b)
        {
            
            return a._numerator == b._numerator && a._denumerator == b._denumerator;
        }


        public static bool operator !=(Fraction a, Fraction b)
        {

            return a._numerator != b._numerator  || a._denumerator != b._denumerator;
        }
    }

   
}
