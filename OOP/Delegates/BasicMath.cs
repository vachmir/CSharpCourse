using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Delegates
{
    class BasicMath
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }

        public static int Square (int x)
        {
            return x * x;
        }

        public int Mul(int x, int y)
        {
            return x * y;
        }
    }
}
