using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("03 Nov 2022", 30, 4.8);
        Swimming swimming = new Swimming("05 Oct 2023", 50, 15);
        Cycling cycling = new Cycling("11 Jul 2023", 40, 27);

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(swimming);
        activities.Add(cycling);

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}