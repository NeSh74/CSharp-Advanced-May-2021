using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace _1_Generic_Box_Of_String
{
    public class Box<T>
    {
        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get; private set; }

        public override string ToString()
        {
            Type valueType = this.Value.GetType();
            string valueTypeFullName = valueType.FullName;
            return $"{valueTypeFullName}: {this.Value}";
        }
    }
}
