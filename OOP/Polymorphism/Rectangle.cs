using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Polymorphism
{
    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return this.width * this.height;
        }

        public override double Perimeter
        {
            get { return 2 * this.width * this.height; }
        }
    }
}
