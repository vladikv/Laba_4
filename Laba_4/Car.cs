using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4
{
    class Car
    {
        public string brand;
        public string color;

        public Car(string brand, string color)
        {
            this.brand = brand;
            this.color = color;
        }


        public virtual void ChangeBrand(string newBrand)
        {
            brand = newBrand;
            Console.WriteLine("Car brand changed.");
        }


        public virtual void ChangeColor(string newColor)
        {
            color = newColor;
            Console.WriteLine("Car color changed.");
        }


        public override string ToString()
        {
            return $"Brand: {brand}, Color: {color}";
        }


        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var car = (Car)obj;
            return brand == car.brand && color == car.color;
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(brand, color);
        }
    }
}
