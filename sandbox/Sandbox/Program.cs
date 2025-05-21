using System;

class Program
{    static void Main(string[] args)
    {
        Circle myCircle = new Circle(10);
        // myCircle.SetRadius(10);
        Console.WriteLine($"{myCircle.GetRadius()}");
        Console.WriteLine($"{myCircle.GetArea()}");

        Cylinder myCylinder = new Cylinder(100, 5);

        Console.WriteLine($"{myCylinder.GetVolume()}");
    }
}