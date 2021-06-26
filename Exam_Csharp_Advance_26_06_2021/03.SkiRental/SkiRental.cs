using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        private List<Ski> data;

        public SkiRental()
        {
            this.data = new List<Ski>();
        }

        public SkiRental(string name, int capacity)
            : this()
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        public string Name { get; set; }

        public int Capacity { get; set; }



        public void Add(Ski ski)
        {
            if (data.Count < Capacity)
            {
                data.Add(ski);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            Ski skiToremove = this.data.FirstOrDefault(m => m.Manufacturer == manufacturer && m.Model == model);

            if (skiToremove == null)
            {
                return false;
            }

            this.data.Remove(skiToremove);
            return true;
        }

        public Ski GetNewestSki()
        {
            return this.data
                .OrderByDescending(a => a.Year)
                .FirstOrDefault();
        }

        public Ski GetSki(string manufacturer, string model)
        {
            Ski ski = this.data
                .FirstOrDefault(m => m.Manufacturer == manufacturer && m.Model == model);
            return ski;
        }
        public int Count => this.data.Count;

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {this.Name}:");
            foreach (Ski ski in this.data)
            {
                sb.AppendLine(ski.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
