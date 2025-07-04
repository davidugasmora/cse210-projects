class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool status)
    : base(name, description, points, status)
    {

    }



    public override void RunGoal()
    {
        Console.Clear();

        Console.Write("\nWhat is the name of the goal you want to create: ");
        string name = Console.ReadLine();
        SetName(name);

        Console.Write("\nWhat is a short description of it? ");
        string description = Console.ReadLine();
        SetDescription(description);

        while (true)
        {
            Console.Write("\nWhat is the amount of points associated with this goal? ");
            string strPoints = Console.ReadLine();

            if (int.TryParse(strPoints, out int points))
            {
                SetPoints(points);
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nInvalid input, please enter an integer");
            }
        }
        
    }
    public override int RecordEvent()
    {
        throw new NotImplementedException();
    }
}