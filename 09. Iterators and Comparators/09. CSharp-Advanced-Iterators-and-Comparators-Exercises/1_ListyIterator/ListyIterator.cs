using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_ListyIterator
{
    public class ListyIterator<T>
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
            if (hasNext )
            {
                this.index++;
            }

            return hasNext;
        }

        public void Print()
        {
            if (this.index >= this.items .Count  )
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(this.items[this.index ]);
        }

        public bool HasNext() => this.index < this.items.Count - 1;

    }
}
