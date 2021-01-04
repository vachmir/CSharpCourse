using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Polymorphism
{
    class RightTriangle : Rectangle
    {
        public RightTriangle(double leg1, double leg2)
           : base(leg1, leg2)
        {
            // Nothing
        }

        public override double GetArea()
        {
            double area = base.GetArea();
            return area / 2;
        }

        public sealed override double Perimeter
        {
            get
            {
                // TODO: Fix the code below
                return base.Perimeter;
            }
        }
    }
}
