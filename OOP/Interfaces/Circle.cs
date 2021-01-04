using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Interfaces
{
    class Circle : Shape
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; private set; }

        public override double Area => Math.PI * this.Radius * this.Radius;

        public override double Perimeter => 2 * Math.PI * this.Radius;

        public override string ToString()
        {
            return $"Circle({this.Radius})";
        }
    }
}
