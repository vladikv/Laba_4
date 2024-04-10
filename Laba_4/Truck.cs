using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4
{
    class Truck : Car
    {
        private double loadCapacity;

        public Truck(string brand, string color, double loadCapacity) : base(brand, color)
        {
            this.loadCapacity = loadCapacity;
        }


        public void ChangeLoadCapacity(double newLoadCapacity)
        {
            loadCapacity = newLoadCapacity;
            Console.WriteLine("Truck load capacity changed.");
        }
    }
}
