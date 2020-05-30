using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass
{
    class ArithmeticProgression: Progression
    {
        private int a, b;
        public ArithmeticProgression(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int GetElement(int k)
        {
            return a + b * (k - 1);            
        }


    }
}
