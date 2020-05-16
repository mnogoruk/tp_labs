using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    class Triangle
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || c + b <= a)
                throw new ArgumentException();

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Print()
        {
            Console.WriteLine("side a = {0}, side b = {1}, side c = {2}", a, b, c);
        }

        public double Are()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt((p - a) * (p - b) * (p - c) * p);
        }

        public double Perimeter()
        {
            return a + b + c;
        }
    }
}
