using System;
using System.Collections.Generic;
using System.Text;

namespace AdvanceTopics
{
    internal class Generics<T>
    {
        public T Value;
        public void show(T value)
        {
            Value = value;
            Console.WriteLine(Value);
        }
        public Generics(T val)
        {
            Value = val;
            Console.WriteLine(Value);
        }
    }
}
