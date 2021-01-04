using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Interfaces
{
    class Square : Rectangle
    {
        public Square(double side)
            : base(side, side)
        {
            // Nothing
        }

        public override string ToString()
        {
            return $"Square({this.Width})";
        }
    }
}
