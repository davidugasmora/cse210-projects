using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running myRunning = new Running("03 Nov 2022", 30, 3.0f);
        activities.Add(myRunning);
        Cycling myCycling = new Cycling("19 Aug 1999", 45, 12.5f);
        activities.Add(myCycling);
        Swimming mySwimming = new Swimming("08 Oct 2015", 20, 10);
        activities.Add(mySwimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}