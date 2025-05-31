using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture myScripture = new Scripture("John", 3, 16, 17, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved.");


        while (true)
        {
            Console.Clear();

            myScripture.ShowScripture();

            Console.WriteLine("Press enter to continue or type 'quit' to to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            
            myScripture.HideSomeWords();
        }
    }
}