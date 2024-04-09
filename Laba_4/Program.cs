using System;


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


class PassengerCar : Car
{
    public PassengerCar(string brand, string color) : base(brand, color)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Truck("Volvo", "black", 10.5);
        Car car2 = new PassengerCar("Toyota", "red");

        car1.ChangeBrand("Tesla");
        car1.ChangeColor("white");

        car2.ChangeBrand("BMW");
        car2.ChangeColor("blue");

        Console.WriteLine(car1.ToString());
        Console.WriteLine(car2.ToString());
    }
}
