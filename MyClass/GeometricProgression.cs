using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    class GeometricProgression : Progression
    {
        private int a, q;
        public GeometricProgression(int a, int q)
        {
            this.a = a;
            this.q = q;
        }
        public override int GetElement(int k)
        {
            return a * (int)Math.Pow(q, (k - 1));
        }
    }
}
