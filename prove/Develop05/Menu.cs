class Menu
{
    private int _userInput;

    public int DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Events");
            Console.WriteLine(" 6. Quit");

            Console.Write("\nSelect a choice from the menu: ");
            string strUserInput = Console.ReadLine();

            if (int.TryParse(strUserInput, out _userInput) && _userInput >= 1 && _userInput <= 6)
            {
                return _userInput;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nInvalid input, please enter a number between 1 and 6.");
            }
        }
    }

    public int DisplayCreateGoalMenu()
    {   while (true)
        {
            Console.WriteLine("\nThe types of Goals are:");
            Console.WriteLine(" 1. Simple Goal");
            Console.WriteLine(" 2. Eternal Goal");
            Console.WriteLine(" 3. Checklist Goal");

            Console.Write("\nWhich type of Goal would you like to create? ");
            string strUserInput = Console.ReadLine();

            if (int.TryParse(strUserInput, out _userInput) && _userInput >= 1 && _userInput <= 3)
            {
                return _userInput;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nInvalid input, please enter a number between 1 and 3.");
            }
        }
    }
}