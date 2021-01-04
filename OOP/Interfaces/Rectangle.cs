using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Interfaces
{
    class Rectangle : Shape //, IPolygon //, ICloneable
    {
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; private set; }
        public double Height { get; private set; }

        public override double Area => this.Width * this.Height;

        public override double Perimeter => 2 * (this.Width + this.Height);

        public override string ToString()
        {
            return $"Rectangle({this.Width}, {this.Height})";
        }
    }
}
