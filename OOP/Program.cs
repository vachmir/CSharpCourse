using System;
using System.Collections;
using System.Collections.Generic;
using OOP.Inheritance;
using OOP.Polymorphism;
using OOP.Interfaces;
using OOP.Enums;
using OOP.Generics;
using OOP.Delegates;
using OOP.Lambdas;
namespace OOP
{
    class Program
    {
        #region Delegates
        public delegate int BinaryOp(int x, int y);
        #endregion

        #region Lambdas

        public delegate void PrintDelegate(string message);
        private static void PrintMethod(string message)
        {
            Console.WriteLine(message);
        }
        #endregion

        static void Main(string[] args)
        {

            #region Delegates
            Console.WriteLine("Delegates");
            BinaryOp add = new BinaryOp(OOP.Delegates.BasicMath.Add);
            int result1 = add(42, 17);
            int resuly2 = add.Invoke(42, 17);

            //BinaryOp error = new BinaryOp( BasicMath.Square());

            OOP.Delegates.BasicMath math = new OOP.Delegates.BasicMath();
            BinaryOp mul = new BinaryOp(math.Mul);

            DisplayDelegateInfo(add);
            DisplayDelegateInfo(mul);

            OOP.Delegates.Cars cars = new Cars(50);

            cars.RegisterEventHndler(new OOP.Delegates.Cars.CarEvent(Program.OnCarEvent));
            cars.RegisterEventHndler(Program.AnptherCarEventHandler);

            //for (int i = 0; i < 5; i++)
            //{
            //    cars.Accelerate(10);
            //    Console.WriteLine($"Car speed: {cars.Speed}");
            //}


            //cars.DeregisterCarEventHandler(Program.OnCarEvent);
            //for (int i = 0; i < 5; i++)
            //{
            //    cars.Accelerate(-10);
            //    Console.WriteLine($"Car speed: {cars.Speed}");
            //}

            //OOP.Delegates.GenericDelegate<string> strDelegate= new GenericDelegate<string>(Program.StringMethod);
            //OOP.Delegates.GenericDelegate<int> intDelegate = new GenericDelegate<int>(Program.StringMethod);

            //strDelegate("Hello World");
            //intDelegate(42);


            //Action<int, int> mathSub = new Action<int, int>(BasicMath.Sub);
            //Action<string> action = Program.OnCarEvent;
            //action("Action is invoked");

            //Func<int, int, int> mathAdd = new Func<int, int, int>(BasicMath.Add);
            //int result3 = mathAdd(42, 17);


            //cars.Started += Program.OnCarEvent;
            //cars.Started += Program.AnptherCarEventHandler;
            //cars.Started("Car started");

            //cars.SpeedChanged += Program.OnCarSpeedChanged;
            #endregion

            #region Enumeration
            Console.WriteLine("Enumeration");
            OOP.Enums.BorderSide topSide = Enums.BorderSide.Top;
            bool isTop = (topSide == OOP.Enums.BorderSide.Top);
            Console.WriteLine(isTop);
            Console.WriteLine($"topSide is {topSide}");
            Console.WriteLine($"BorderSide is {BorderSide.Top}" );
            Console.WriteLine($"Size of BorderSide enum is {sizeof(BorderSide)}");
            #endregion


            #region Generics
            Console.WriteLine("Generics");
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
            Console.WriteLine("INheritance");
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

            #region Lambdas
            Console.WriteLine("Lambdas");
            //C# 1.0
            PrintDelegate print1 = new PrintDelegate(Program.PrintMethod);

            //C# 2.0
            PrintDelegate print2 = delegate (string msg) { Console.WriteLine(msg); };

            //C# 3.0
            PrintDelegate print3 = (string msg) => Console.WriteLine(msg);

            print1("Hello");
            print2("C Sharp");
            print3("Language");

            Func<int, int, int> mathAdd = (int x, int y) => x + y;
            Func<int, int> mathAbs =
                (int x) =>
                {
                    if (x < 0)
                        return -x;
                    else
                        return x;
                };

            List<int> numbers = new List<int> { 42, 17, 65, 24, 31, 6, 58, 0 };

            List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);
            foreach (int number in evenNumbers)
                Console.Write($"{number}, ");
            Console.WriteLine();
                    

             int denominator = int.Parse(Console.ReadLine());

            int local = 0;
            Action action = () => Console.WriteLine($"Value: {local}");

            local = 1;
            action();

            #endregion

            #region Polymorphism
            Console.WriteLine("Polymorphism");
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
            Console.WriteLine("Interface");
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

        #region Delegates
        public static void DisplayDelegateInfo(BinaryOp delegateObject)
        {
            foreach (Delegate d in delegateObject.GetInvocationList())
            {
                Console.WriteLine($"Method name: {d.Method}");
                Console.WriteLine($"Target type: {d.Target?.GetType()}");
            }
        }

        public static void OnCarEvent(string message)
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void AnptherCarEventHandler(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void StringMethod(string arg)
        {
            Console.WriteLine($"StringMethod({arg}) is invoked");
        }

        private static void IntMethod(int arg)
        {
            Console.WriteLine($"IntMethod({arg}) is invoked");
        }

        private static void OnCarSpeedChanged(object sender, CarEventArgs args)
        {
            Console.WriteLine(
                $"The car speed changed from {args.OldSpeed} to {args.NewSpeed}.");
        }
        #endregion

        #region Lambdas
        private static Action ClosureSample()
        {
            int local = 0;
            Action action = () => Console.WriteLine($"Value: {local}");

            local = 1;
            return action;
        }
        #endregion

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
