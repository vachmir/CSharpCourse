using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Polymorphism
{
    class Square : Rectangle
    {
        public Square(double side)
            : base(side, side)
        {
            // Nothing
        }
    }
}
