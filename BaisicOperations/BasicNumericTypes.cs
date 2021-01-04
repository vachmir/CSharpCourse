using System;
using System.Collections.Generic;
using System.Text;

namespace BaisicOperations
{
    class BasicNumericTypes
    {
        public void BasicNumericTypesMethod()
        {
            int x = 12345; // int is a 32-bit integer
            long y = x; // Implicit conversion to 64-bit integer
            short z = (short)x; // Explicit conversion to 16-bit integer

            Console.WriteLine(1.0.GetType()); // Double (double)
            Console.WriteLine(1E06.GetType()); // Double (double)
            Console.WriteLine(1.GetType()); // Int32 (int)
            Console.WriteLine(0xF0000000.GetType()); // UInt32 (uint)
            Console.WriteLine(0x100000000.GetType()); // Int64 (long)

            Console.WriteLine(1.0 / 0.0); // Infinity
            Console.WriteLine(-1.0 / 0.0); // -Infinity
            Console.WriteLine(1.0 / -0.0); // -Infinity
            Console.WriteLine(-1.0 / -0.0); // Infinity

            Console.WriteLine(0.0 / 0.0); // NaN
            Console.WriteLine((1.0 / 0.0) - (1.0 / 0.0)); // NaN

            string s = null;
            Console.WriteLine(s?[0]); // 
        }
    }
}
