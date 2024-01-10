using System;
using System.Collections.Generic;

class Car : IEquatable<Car>
{
    public string Name { get; set; }
    public string Engine { get; set; }
    public int MaxSpeed { get; set; }

    public override string ToString()
    {
        return Name;
    }

    public bool Equals(Car other)

    {
        if (other == null)
            return false;

        return Name == other.Name &&
            Engine == other.Engine &&
            MaxSpeed == other.MaxSpeed;
    }
}

class CarsCatalog
{
    private List<Car> cars = new List<Car>();
    public string this[int index]
    {
        get { return $"{cars[index].Name} - {cars[index].Engine}"; }
        set { cars[index] = new Car { Name = value, Engine = "", MaxSpeed = 0 }; }
    }

    public void AddCar(Car car)
    {
        cars.Add(car);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car { Name = "Toyota GR86", Engine = "V4", MaxSpeed = 240 };
        Car car2 = new Car { Name = "BMW M4", Engine = "V6", MaxSpeed = 300 };
        Car car3 = new Car { Name = "Igor", Engine = "ZadnePrivodnyi", MaxSpeed = -1 };

        Console.WriteLine(car1);
        Console.WriteLine(car2);
        Console.WriteLine(car3);

        Console.WriteLine(car1.Equals(car2));
        Console.WriteLine(car3.Equals(car1));

        CarsCatalog catalog = new CarsCatalog();
        catalog.AddCar(car1);
        catalog.AddCar(car2);
        catalog.AddCar(car3);

        Console.WriteLine(catalog[0]);
        Console.WriteLine(catalog[1]);
        Console.WriteLine(catalog[2]);

        catalog[0] = "Voyah";
        Console.WriteLine(catalog[0]);
    }

}