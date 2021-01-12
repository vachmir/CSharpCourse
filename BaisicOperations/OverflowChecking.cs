using System;
using System.Collections.Generic;
using System.Text;

namespace BaisicOperations
{
    class OverflowChecking
    {
        public void Checking()
        {
            //int x = int.MaxValue + 1; // Larger than range
            int x = int.MaxValue - 1;
            Console.WriteLine($"Int MaxValue is {int.MaxValue}");
            Console.WriteLine($"Initial value: {x}");
            x++;
            Console.WriteLine($"After 1st incrementing: {x}");
            x++;
            Console.WriteLine($"After 2nd incrementing: {x}");
            x++;
            Console.WriteLine($"After 3rd incrementing: {x}");
            Console.WriteLine();

            unchecked //Disables compile-time check
            {
                Console.WriteLine("Unchecked");
                int z = int.MaxValue + 1;             
                Console.WriteLine($"Initial value: {z}");
                z--;
                Console.WriteLine($"After 1st decrementing: {z}");
                z--;
                Console.WriteLine($"After 2nd decrementing: {z}");
                z--;
                Console.WriteLine($"After 3rd decrementing: {z}");
                Console.WriteLine();
            }            

            checked    //Makes a runtime exception, alows us to avoid reduntant mathematical operations
            {
                Console.WriteLine("Checked");
                int y = int.MaxValue - 1;
                Console.WriteLine($"Int MaxValue is {int.MaxValue}");
                Console.WriteLine($"Initial value: {y}");
                y++;
                Console.WriteLine($"After 1st incrementing: {y}");
                y++;
                Console.WriteLine($"After 2nd incrementing: {y}");
                y++;
                Console.WriteLine($"After 3rd incrementing: {y}");
            }           

        }

    }
}
