using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        while (true)
        {
            Console.Clear();

            int menuChoice = myMenu.DisplayMenu();

            switch (menuChoice)
            {
                case 1:
                    while (true)
                    {
                        Console.Clear();

                        int goalMenuChoice = myMenu.DisplayCreateGoalMenu();

                        switch (goalMenuChoice)
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                        }
                    }

                    
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    return;
            }
        }
    }
}