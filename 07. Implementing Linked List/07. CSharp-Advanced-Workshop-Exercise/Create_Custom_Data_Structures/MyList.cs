using System;
using System.Collections.Generic;
using System.Text;

namespace Create_Custom_Data_Structures
{
    public class MyList
    {
        private int defaultCapacity;
        private int[] data;

        public MyList()
        : this(4)
        {

        }

        public MyList(int defaultCapacity)
        {
            this.defaultCapacity = defaultCapacity;
            this.data = new int[defaultCapacity];
        }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                return this.data[index];
            }
            set
            {
                this.data[index] = value;
            }
        }

        public void Add(int number)
        {
            //if (this.Count == this.data.Length)
            //{
            //    Resize();
            //}
            CheckIfResizeIsNeeded();
            this.data[this.Count] = number;
            this.Count++;
        }

        public void Clear()
        {
            this.Count = 0;
            this.data = new int[this.defaultCapacity];
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.data[i] == element)
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            this.ValidateIndex(firstIndex);
            this.ValidateIndex(secondIndex);
            var firstValue = this.data[firstIndex];
            this.data[firstIndex] = this.data[secondIndex];
            this.data[secondIndex] = firstValue;
        }

        public void InsertAt(int index, int element)
        {
            this.ValidateIndex(index);
            this.Count++;
            CheckIfResizeIsNeeded();
            //for (int i = this.Count-1; i >=index ; i--)
            //{
            //    this.data[i + 1] = this.data[i];
            //}
            this.ShiftRight(index);
            this.data[index] = element;
        }

        public int RemoveAt(int index)
        {
            //Validate index
            //Decrease count
            //Move data to the left after the index
            this.ValidateIndex(index);
            var result = this.data[index];
            Shiftleft(index);
            this.Count--;
            return result;
        }

        private void Shiftleft(int index)
        {
            for (int i = index + 1; i < this.Count; i++)
            {
                this.data[i - 1] = this.data[i];
            }
        }

        private void ShiftRight(int index)
        {
            for (int i = this.Count - 1; i >= index; i--)
            {
                this.data[i + 1] = this.data[i];
            }
        }

        private void CheckIfResizeIsNeeded()
        {
            if (this.Count == this.data.Length)
            {
                Resize();
            }
        }

        private void Resize()
        {
            var newCapacity = this.data.Length * 2;
            var newData = new int[newCapacity];
            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }

            this.data = newData;
        }

        private void ValidateIndex(int index)
        {
            if (index >= 0 && index < this.Count)
            {
                return;
            }

            var message = this.Count == 0
                ? "The list is empty"
                : $"The list has {this.Count } elements and it's zero-based";
            throw new ArgumentException($"Index was out of range. {message}");
        }
    }
}
