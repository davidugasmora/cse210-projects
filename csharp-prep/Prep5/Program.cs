using System;

class Program
{   
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What's your name? ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What's your favorite number? ");
        string strNumber = Console.ReadLine();
        int number = int.Parse(strNumber);

        return number;
    }

    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;

        return squaredNumber;
    }

    static void DisplayResult(int squaredNumber, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);
        
        DisplayResult(squaredNumber, userName);
    }
}