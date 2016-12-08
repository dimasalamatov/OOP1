using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        public class Fraction
        {
            protected int numerator;
            protected int denominator;
            protected int intPart;

            public Fraction()
            {
                numerator = 0;
                denominator = 1;
                intPart = 0;
            }
            public Fraction(int num, int den)
            {
                numerator = num;
                denominator = den;
                intPart = 0;
            }
            public void Cancelation()
            {
                if (numerator != 0)
                {
                    int m = denominator, n = numerator, ost = m % n;
                    while (ost != 0)
                    {
                        m = n;
                        n = ost;
                        ost = m % n;
                    }
                    int nod = n;
                    if (nod != 1)
                    {
                        numerator /= nod;
                        denominator /= nod;
                    }
                }
            }
            public void Show()
            {
                Console.Write(numerator + "/" + denominator);
                Console.WriteLine();
            }

            public static Fraction operator + (Fraction A, Fraction B)
            {
                A.Cancelation();
                B.Cancelation();
                Fraction C = new Fraction();
                C.denominator = A.denominator * B.denominator;
                C.numerator = A.numerator * B.denominator + A.denominator * B.numerator;
                C.Cancelation();
                return C;   
            }
            public static Fraction operator + (Fraction A, int b)
            {
                A.Cancelation();
                Fraction C = new Fraction();
                C.numerator = A.numerator + b * A.denominator;
                C.denominator = A.denominator;
                C.Cancelation();
                return C;
            }
            public static Fraction operator + (int b, Fraction A)
            {
                A.Cancelation();
                Fraction C = new Fraction();
                C.numerator = A.numerator + b * A.denominator;
                C.denominator = A.denominator;
                C.Cancelation();
                return C;
            }
            public static Fraction operator - (Fraction A, Fraction B)
            {
                A.Cancelation();
                B.Cancelation();
                Fraction C = new Fraction();
                C.denominator = A.denominator * B.denominator;
                C.numerator = A.numerator * B.denominator - A.denominator * B.numerator;
                C.Cancelation();
                return C;
            }
            public static Fraction operator - (Fraction A, int b)
            {
                A.Cancelation();
                Fraction C = new Fraction();
                C.numerator = A.numerator - b * A.denominator;
                C.denominator = A.denominator;
                C.Cancelation();
                return C;
            }
            public static Fraction operator - (int b, Fraction A)
            {
                A.Cancelation();
                Fraction C = new Fraction();
                C.numerator =  b * A.denominator - A.numerator;
                C.denominator = A.denominator;
                C.Cancelation();
                return C;
            }
            public static Fraction operator * (Fraction A, Fraction B)
            {
                Fraction C = new Fraction();
                C.numerator = A.numerator * B.numerator;
                C.denominator = A.denominator * B.denominator;
                C.Cancelation();
                return C;
            }
            public static Fraction operator * (Fraction A, int b)
            {
                Fraction C = new Fraction();
                C.denominator = A.denominator;
                C.numerator = A.numerator * b;
                C.Cancelation();
                return C;
            }
            public static Fraction operator * (int b, Fraction A)
            {
                Fraction C = new Fraction();
                C.denominator = A.denominator;
                C.numerator = A.numerator * b;
                C.Cancelation();
                return C;
            }
            public static Fraction operator / (Fraction A, Fraction B)
            {
                Fraction C = new Fraction();
                C.numerator = A.numerator * B.denominator;
                C.denominator = A.denominator * B.numerator;
                C.Cancelation();
                return C;
            }
            public static Fraction operator / (Fraction A, int b)
            {
                Fraction C = new Fraction();
                C.numerator = A.numerator;
                C.denominator = A.denominator * b;
                C.Cancelation();
                return C;
            }
            public static Fraction operator / (int b, Fraction A)
            {
                Fraction C = new Fraction();
                C.numerator = b * A.denominator;
                C.denominator = A.numerator;
                C.Cancelation();
                return C;
            }
            public static explicit operator double (Fraction A)
            {
                double x = A.numerator / A.denominator;
                return x;
            }
            public static bool operator == (Fraction A, Fraction B)
            {
                A.Cancelation();
                B.Cancelation();
                if ((A.numerator == B.numerator) && (A.denominator == B.denominator))
                {
                    return true;
                }
                else { return false; }
            }
            public static bool operator != (Fraction A, Fraction B)
            {
                if (A == B)
                {
                    return false;
                }
                else { return true; }
            }
            public static bool operator > (Fraction A, Fraction B)
            {
                if ((double)A > (double)B)
                {
                    return true;
                }
                else { return false; }
            }
            public static bool operator < (Fraction A, Fraction B)
            {
                if ((double)A < (double)B)
                {
                    return true;
                }
                else { return false; }
            }
            public static bool operator >= (Fraction A, Fraction B)
            {
                if ((double)A >= (double)B)
                {
                    return true;
                }
                else { return false; }
            }
            public static bool operator <= (Fraction A, Fraction B)
            {
                if ((double)A <= (double)B)
                {
                    return true;
                }
                else { return false; }
            }
        }
        static void Main(string[] args)
        {
            Fraction A = new Fraction(4, 9);
            Fraction B = new Fraction(1, 2);
            Fraction D = new Fraction(8, 18);
            A.Cancelation();
            Fraction C = A + B;
            C.Show();
            C = A + 4;
            C.Show();
            C = 4 + A;
            C.Show();
            C = A - B;
            C.Show();
            C = 1 - A;
            C.Show();
            C = A * B;
            C.Show();
            C = A * -2;
            C.Show();
            C = A / B;
            C.Show();
            C = A / 3;
            C.Show();
            C = 4 / A;
            C.Show();
            if (A == D)
            {
                Console.WriteLine("Equal");
            }
            else { Console.WriteLine("Not equal"); }
            if (A != B)
            {
                Console.WriteLine("Not equal");
            }
            else { Console.WriteLine("Equal"); }
            if (A > B)
            {
                Console.WriteLine("A > B");
            }
            else { Console.WriteLine("A <= B"); }
            if (D < C)
            {
                Console.WriteLine("D < C");
            }
            else { Console.WriteLine("D >= C"); }
            if (A >= B)
            {
                Console.WriteLine("A >= B");
            }
            else { Console.WriteLine("A < B"); }
            if (D <= C)
            {
                Console.WriteLine("D <= C");
            }
            else { Console.WriteLine("D >= C"); }
        }
    }
}
