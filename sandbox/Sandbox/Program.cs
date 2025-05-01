using System;

class Program
{
    static double Addnumbers(double a, double b)
    {
        return a + b;
    }

    static void DisplayGreeting()
    {
        Console.WriteLine("Hello Bob, how are you?");
    }

    static void Main(string[] args)
    {

        int x = 10;
        if (x == 10)
        {
            Console.WriteLine("X is 10");
        }

        for (int i = 0; i < x; i++)
        {
            Console.WriteLine($"Bob is cool: {i}");
        }

        List<int> myNumbers = new List<int>();
        myNumbers.Add(10);
        myNumbers.Add(99);
        myNumbers.Add(-123);

        foreach (int myNumber in myNumbers)
        {
            Console.WriteLine(myNumber);
        }
        
        // This is a fun comment.

        double total = Addnumbers(123.4546, 987.1234);
        Console.WriteLine(total);

        DisplayGreeting();

        bool done = false;

        while (!done)
        {
            done = true;
        }

        do 
        {
            Console.WriteLine("");
        }while(!done);

    }
}