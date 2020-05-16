using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Utils
{
    class Operation
    {


        public static int squareRoot(double a, double b, double c, out double x1, out double x2)
        {
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D < 0)
            {
                x1 = 0;
                x2 = 0;
                return -1;

            }else if (D == 0)
            {
                x1 = x2 = -(b / a);
                return 0;
            }
            else
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                return 1;
            }

        }


        public static bool isTtiangle(double a, double b, double c)
        {
            if (a + b <= c)
                return false;
            if (a + c <= b)
                return false;
            if (c + b <= a)
                return false;
            return true;
        }

        public static double area(double a, double b, double c)
        {
            if (!isTtiangle(a, b, c))
                throw new ArgumentException();
            double p = (a + b + c) / 2;
            return Math.Sqrt((p - a) * (p - b) * (p - c) * p);
        }

        public static double area(double c)
        {
            return area(c, c, c);
        }

    }
}
