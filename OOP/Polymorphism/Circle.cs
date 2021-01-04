using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Polymorphism
{
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * this.radius * this.radius;
        }

        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * this.radius;
            }
        }

        public double Diameter
        {
            get { return 2 * this.radius; }
        }

        public override string ToString()
        {
            return $"Circle({this.radius})";
        }
    }
}
