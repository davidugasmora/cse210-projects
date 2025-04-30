using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int add_num = -1;

        while (add_num != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string str_add_num = Console.ReadLine();
            add_num = int.Parse(str_add_num);

            if (add_num != 0)
            {
                numbers.Add(add_num);
            }
        }

        int sum = 0;
        int largest = numbers[0];

        foreach (int number in numbers)
        {
            sum += number;

            if (number > largest)
            {
                largest = number;
            }
        }

        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}