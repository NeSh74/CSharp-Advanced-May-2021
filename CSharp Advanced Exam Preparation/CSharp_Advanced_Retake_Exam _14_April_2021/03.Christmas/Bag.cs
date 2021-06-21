using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Christmas
{
    public class Bag
    {
        private List<Present> data;

        public string Color { get; set; }

        public int Capacity { get; set; }

        public int Count => data.Count;

        public Bag(string color, int capacity)
        {
            Color = color;
            Capacity = capacity;
            data = new List<Present>();
        }

        public void Add(Present present)
        {
            if (Capacity > Count)
            {
                data.Add(present);
            }
        }

        public bool Remove(string name)
        {
            Present present = data.FirstOrDefault(x => x.Name == name);
            return data.Remove(present);
        }

        public Present GetHeaviestPresent()
        {
            Present heaviestPresent = data.OrderByDescending(x => x.Weight).FirstOrDefault();
            return heaviestPresent;
        }

        public Present GetPresent(string name)
        {
            Present currentPresent = data.FirstOrDefault(x => x.Name == name);
            return currentPresent;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} bag containes:");
            foreach (var present in data)
            {
                sb.AppendLine(present .ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
