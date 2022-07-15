using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutekDirask
{
    /// <summary>
    /// Klasa ułamek
    /// </summary>

    public class Fraction : IEquatable<Fraction>, IComparable<Fraction>
    {
        private int numerator; //licznik
        private int denominator; //mianownik

        public int Numerator { get => numerator; }
        public int Denominator { get => denominator; }

        public Fraction() // konstruktor domyślny
        {
            numerator = 1;
            denominator = 1;
        }

        public Fraction(int num, int den) // konstruktor normalny
        {
            numerator = num;
            denominator = den;
        }

        public Fraction(Fraction fraction)
        {
            numerator = fraction.numerator;
            denominator = fraction.denominator;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
             return new Fraction(a.numerator * b.denominator + b.numerator * a.denominator, a.denominator * b.denominator);
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(a.numerator * b.denominator - b.numerator * a.denominator, a.denominator * b.denominator);
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.numerator * b.numerator, a.denominator*b.denominator);
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            if(b.numerator == 0 || a.denominator == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(a.numerator * b.denominator, a.denominator * b.numerator);
        }

        public override string ToString()
        {
            return numerator + " / " + denominator;
        }

        public bool Equals(Fraction other)
        {
            if(other == null)
            {
                return false;
            }

            if(this.numerator == other.numerator && this.denominator == other.denominator)
            {
                return true;
            }else
            {
                return false;
            }
        }

        public int CompareTo(Fraction other)
        {
            int result = (this.numerator * other.denominator).CompareTo(this.denominator * other.numerator);

            if(result == 0)
            {
                result = this.numerator.CompareTo(other.numerator);
            }

            return result;
        }

        public int toFloor()
        {
            return (int)Math.Floor(((double)numerator / (double)denominator));
        }

        public int toCeil()
        {
            return (int)Math.Ceiling(((double)numerator / (double)denominator));
        }


    }
}
