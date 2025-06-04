using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("David Ugas Mora", "Mathematics");
        Console.WriteLine(myAssignment.GetSummary());

        MathAssignment myMathAssignment = new MathAssignment("David Wirss Mora", "Mathematicsss", "Section 7.3", "Problems 8-19");
        Console.WriteLine(myMathAssignment.GetSummary());
        Console.WriteLine(myMathAssignment.GetHomeworkList());

        WrittingAssignment myWrittingAssignment = new WrittingAssignment("David Ugas Vilass", "European History", "The Causes of World War II");
        Console.WriteLine(myWrittingAssignment.GetSummary());
        Console.WriteLine(myWrittingAssignment.GetWrittingInformation());
    }
}