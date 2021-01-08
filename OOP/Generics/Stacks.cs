using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Generics
{
    class Stacks <T>
    {
        int posoition;
        T[] data = new T[100];
        public void Push(T obj) => data[posoition++] = obj;
        public T Pop() => data[--posoition];

        public Stacks<T> st = new Stacks<T>();
    }
}
