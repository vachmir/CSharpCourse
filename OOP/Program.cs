using System;
using System.Collections;
using OOP.Inheritance;
using OOP.Polymorphism;
using OOP.Interfaces;
using OOP.Enums;
using OOP.Generics;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Enumeration

            OOP.Enums.BorderSide topSide = Enums.BorderSide.Top;
            bool isTop = (topSide == OOP.Enums.BorderSide.Top);
            Console.WriteLine(isTop);
            Console.WriteLine($"topSide is {topSide}");
            Console.WriteLine($"BorderSide is {BorderSide.Top}" );
            Console.WriteLine($"Size of BorderSide enum is {sizeof(BorderSide)}");
            #endregion


            #region Generisc
            var stack = new OOP.Generics.Stacks<int>();
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            Console.WriteLine($"Stack member is {stack.Pop()}, {stack.Pop()}");

            var stackString = new OOP.Generics.Stacks<string>();
            stackString.Push("Armenia");
           // stackString.Push(string.Empty);
            stackString.Push("South Korea");
            Console.WriteLine($"{stackString.Pop()}, {stackString.Pop()}");



            #endregion


            #region Inheritance
            OOP.Inheritance.Car car = new OOP.Inheritance.Car();
            car.Speed = 60;

            OOP.Inheritance.Bus bus = new OOP.Inheritance.Bus();
            bus.Speed = 40;

            // TODO: Create class diagram

            OOP.Inheritance.Manager garegin = new OOP.Inheritance.Manager("Garegin", age: 42, salary: 1_800_000, ssn: "12345678", stopOptions: 1500);
            OOP.Inheritance.SalesPerson marine = new OOP.Inheritance.SalesPerson();



            IEnumerator ie = new OOP.Interfaces.Countdown();

            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Current);
            }



            ((OOP.Interfaces.ILogger)new OOP.Interfaces.Countdown()).Log("message");

            #endregion


            #region Polymorphism

            OOP.Polymorphism.Circle circle = new OOP.Polymorphism.Circle(1);
            OOP.Polymorphism.Shape shape = new OOP.Polymorphism.Circle(1);
            Console.WriteLine($"The area of circle with radius 1 is {circle.GetArea()}");
            Console.WriteLine($"The area of shape is {shape.GetArea()}");

            //Shape[] shapes = LoadShapesFromDatabase();

            //double area = 0, perimeter = 0;
            //foreach (Shape shape in shapes)
            //{
            //    area += shape.GetArea();
            //    perimeter += shape.Perimeter;
            //}

            //Console.WriteLine($"Total area of all shapes: {area}");
            //Console.WriteLine($"Total perimeter of all shapes: {perimeter}");

            // Downcasting example
            //Circle downcastedCircle = (Circle)shape;
            //Rectangle rectangle = (Rectangle)shape;

            //if (rectangle != null)
            //    Console.WriteLine($"Shape is a rectangle.");
            //else
            //    Console.WriteLine("Shape is not a rectangle");

            //if (shape is Circle)
            //{
            //    Circle c = (Circle)shape;
            //    Console.WriteLine($"Diameter: {c.Diameter}");
            //}

            //// Override ToString method.
            //Console.WriteLine();
            //Console.WriteLine("We received the following shapes from the database:");
            //foreach (Shape shape in shapes)
            //{
            //    Console.WriteLine($"A {shape} with area {shape.GetArea()} and perimeter {shape.Perimeter}");
            //}
            #endregion


            #region Interfaces
            double totalArea = 0;
            foreach (OOP.Interfaces.Shape shapee in LoadShapesFromDatabaseI())
            {
               shapee.Print();
                totalArea += shapee.Area;
            }

            Console.WriteLine();
            Console.WriteLine($"Total area: {totalArea}");

            #endregion
        }

        #region Polymorphism
        private static OOP.Polymorphism.Shape[] LoadShapesFromDatabaseP()
        {
            return new OOP.Polymorphism.Shape[]
                {
                    new OOP.Polymorphism.Rectangle(1, 2), //2 folders contain same class, so we must specify the place
                    new OOP.Polymorphism.Circle(1), 
                    new OOP.Polymorphism.Square(2),
                    new OOP.Polymorphism.Rectangle(3, 4),
                    new OOP.Polymorphism.RightTriangle(3, 4),
                };            
        }

        #endregion


        #region Interfaces

        static OOP.Interfaces.Shape[] LoadShapesFromDatabaseI()
        {
            return new OOP.Interfaces.Shape[]
            {
                new OOP.Interfaces.Circle(1),
                new OOP.Interfaces.RightTriangle(3, 4),
                new OOP.Interfaces.Rectangle(3, 4),
                new OOP.Interfaces.Circle(2),
                new OOP.Interfaces.Square(2),
            };
        }

        static IEnumerable EnumerateShapes()
        {
            yield return new OOP.Interfaces.Rectangle(2, 5);
            yield return new OOP.Interfaces.RightTriangle(8, 6);
            yield return new OOP.Interfaces.Circle(3);
        }


        static IEnumerable Fibonacci()
        {
            int f1 = 0, f2 = 1;

            while (true)
            {
                int newFibonacci = f1 + f2;
                f1 = f2;
                f2 = newFibonacci;
                yield return f1;
            }
        }

        #endregion

    }
}
