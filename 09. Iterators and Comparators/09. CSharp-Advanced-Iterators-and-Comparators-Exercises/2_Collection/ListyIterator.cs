using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

namespace _2_Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> items;

        private int index;

        public ListyIterator(List<T> items)
        {
            this.items = items;
            this.index = 0;
        }

        public ListyIterator(params T[] items)
        {
            this.items = items.ToList();
            this.index = 0;
        }

        public bool Move()
        {
            bool hasNext = this.HasNext();
            if (hasNext)
            {
                this.index++;
            }

            return hasNext;
        }

        public void Print()
        {
            if (this.index >= this.items.Count)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(this.items[this.index]);
        }

        public bool HasNext() => this.index < this.items.Count - 1;

        public IEnumerator<T> GetEnumerator()
        {
            //foreach (T item in this.items)
            //{
            //    yield return item;
            //}
            return new Enumerator(this.items);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class Enumerator : IEnumerator<T>
        {
            private List<T> elements;

            private int index;

            public Enumerator(List<T> elements)
            {
                this.elements = elements;
                this.index = -1;
            }

            public bool MoveNext()
            {
                bool hasNext = this.index < this.elements.Count - 1;
                if (hasNext )
                {
                this.index++;
                }

                return hasNext;
            }

            public void Reset()
            {
                this.index = -1;
            }

            public T Current
            {
                get
                {
                    if (this.index >= this.elements.Count|| this.index==-1 )
                    {
                        throw new InvalidOperationException("Invalid operation!");
                    }
                    return this.elements[this.index];
                }
            }

            object IEnumerator.Current => Current;

            public void Dispose() { }
        }
    }
}
