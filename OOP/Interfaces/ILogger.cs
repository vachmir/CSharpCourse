using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Interfaces
{
    interface ILogger
    {
        void Log (string text) //=> Console.WriteLine(text);
        {
            Console.WriteLine(text);
        }
    }
}
