using System;

class Program
{
    static void TestByRef(int x, ref string name)
    {
        x++;
        name += "Plus Betty.";
        Console.WriteLine($"In TestByRef: {x}, {name}");
    }

    static void TestByOut(out int x)
    {
        x = 120;
        Console.WriteLine($"In TestByRef: {x}");
    }

    static void Main(string[] args)
    {
        int x = 10;
        string name = "Bob ";

        TestByRef(x, ref name);

        Console.WriteLine($"In Main: {x}, {name}");

        int z;

        TestByOut(out z);
        Console.WriteLine($"In main: {z}");
    }
}