using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Polymorphism
{
    abstract class Shape
    {
        protected int shapeId;

        public abstract double GetArea();

        public abstract double Perimeter
        {
            get;
        }
    }
}
