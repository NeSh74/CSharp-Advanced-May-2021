using System;
using System.Collections.Generic;
using System.Text;

namespace _7.Raw_Data
{
    public class Car
    {
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public Tire[] Tire { get; set; }

        public Car(string model, Engine engine, Cargo cargo, Tire [] tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tire = tires;
        }
    }
}
