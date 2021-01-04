using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Interfaces
{
    abstract class Shape
    {
        private int shapeId;

        public abstract double Area { get; }

        public abstract double Perimeter { get; }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
