using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Interfaces
{
    class RightTriangle : Triangle
    {
        public RightTriangle(double legA, double legB)
           : base(legA, legB, Math.Sqrt(legA * legA + legB * legB))
        {
            // Nothing
        }

        public override string ToString()
        {
            return $"RightTriangle({this.SideA}, {this.SideB})";
        }
    }
}
