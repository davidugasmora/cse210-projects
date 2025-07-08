using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        Goals myGoals = new Goals();

        while (true)
        {
            myGoals.DisplayScore();

            int menuChoice = myMenu.DisplayMenu();

            switch (menuChoice)
            {
                case 1:
                    
                    int goalMenuChoice = myMenu.DisplayCreateGoalMenu();
                    switch (goalMenuChoice)
                    {
                        case 1:
                            SimpleGoal mySimplyGoal = new SimpleGoal();
                            mySimplyGoal.RunGoal();
                            myGoals.AddGoal(mySimplyGoal);
                            break;
                        case 2:
                            EternalGoal myEternalGoal = new EternalGoal();
                            myEternalGoal.RunGoal();
                            myGoals.AddGoal(myEternalGoal);
                            break;
                        case 3:
                            CheckListGoal myCheckListGoal = new CheckListGoal();
                            myCheckListGoal.RunGoal();
                            myGoals.AddGoal(myCheckListGoal);
                            break;
                    }
                    break;

                case 2:
                    myGoals.DisplayGoals();
                    break;
                case 3:
                    myGoals.SaveGoals();
                    break;
                case 4:
                    myGoals.LoadGoals();
                    break;
                case 5:
                    myGoals.RecordEvent();
                    break;
                case 6:
                    return;
            }
        }
    }
}