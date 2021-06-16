using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodStrings
{
    public class Box<T> : IComparable
        where T : IComparable
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

        public int CompareTo(object obj)
        {
            Box<T> box = obj as Box<T>;
            int compare = this.Value.CompareTo(box.Value);
            return compare;
        }
    }
}
