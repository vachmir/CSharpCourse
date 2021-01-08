using System;
using System.Collections;
using System.Text;

namespace OOP.Interfaces
{
    class Countdown : IEnumerator, ILogger
    {
        int count = 11;
        public bool MoveNext() => count-- > 0;
        public object Current => count;
        public void Reset() { throw new NotSupportedException(); }



    }
}
