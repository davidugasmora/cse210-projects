using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_num = randomGenerator.Next(1, 100);

        bool is_done = false;

        while (!is_done)
        {
            Console.Write("What is your guess? ");
            string str_guess = Console.ReadLine();
            int guess = int.Parse(str_guess);

            if (magic_num > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magic_num < guess)
            {
                Console.WriteLine("Lower");
            }
            else if (magic_num == guess)
            {
                Console.WriteLine("You guessed it!");
                is_done = true;
            }
        }

        
    }
}