using System;
using System.Collections.Generic;
using System.Text;

namespace _2.Generic_Box_Of_Integer
{
    public class Box<T>
    {
        public Box(T element)
        {
            Element = element;
        }

        public T Element { get; }

        public override string ToString()
        {
            return $"{typeof(T)}: {Element}";
        }
    }
}
