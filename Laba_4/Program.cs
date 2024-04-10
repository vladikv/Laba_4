using System;

namespace Laba_4
{
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
}
