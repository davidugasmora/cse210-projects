using System;

class Program
{
    static void Main(string[] args)
    {
        void DisplayMenuOptions()
        {
            Console.WriteLine("Menu Option:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflection activity");
            Console.WriteLine(" 3. Start Listing activity");
            Console.WriteLine(" 4. Quit");
        }

        int GetInput()
        {
            int userInput;
            while (true)
            {
                Console.Write("Select a choice from the menu: ");
                string strUserInput = Console.ReadLine();

                if (int.TryParse(strUserInput, out userInput) && userInput >= 1 && userInput <= 4)
                {
                    return userInput;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number between 1 and 4.");
                }
            }
        }

        string breathingName = "Breathing";
        string breathingDescription = "relax by walking you through breathing in and out slowly. "
                                    + "Clear your mind and focus on your breathing.";

        string reflectionName = "Reflection";
        string reflectionDescription = "reflect on times in your life when you have shown strength "
                                     + "and resilience. This will help you recognize the power you have "
                                     + "and how you can use it in other aspects of your life.";

        string listingName = "Listing";
        string listingDescription = "reflect on the good things in your life by having "
                                  + "you list as many things as you can in a certain area.";



        

        while (true)
        {
            Console.Clear();

            DisplayMenuOptions();
            int menuChoice = GetInput();

            switch (menuChoice)
            {
                case 1:
                    BreathingActivity myBreathing = new BreathingActivity(breathingName, breathingDescription);
                    myBreathing.RunBreathingActivity();
                    break;
                case 2:
                    ReflectionActivity myReflection = new ReflectionActivity(reflectionName, reflectionDescription);
                    myReflection.RunReflectionActivity();
                    break;
                case 3:
                    ListingActivity myListing = new ListingActivity(listingName, listingDescription);
                    myListing.RunListingActivity();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Exiting the Mindfulness Program...");
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}