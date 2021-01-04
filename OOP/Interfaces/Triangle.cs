using System;
using static System.Math;
using System.Text;

namespace OOP.Interfaces
{
    class Triangle : Shape
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }

        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public override double Area
        {
            get
            {
                // Heron's formula
                double p = this.Perimeter / 2;
                return Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            }
        }

        public override double Perimeter => this.SideA + this.SideB + this.SideC;

        public override string ToString()
        {
            return $"Triangle({this.SideA}, {this.SideB}, {this.SideC})";
        }
    }
}
