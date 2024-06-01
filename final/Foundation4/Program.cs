using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of different activity types
        Running running = new Running("03 May 2024", 37, 4.8);
        Swimming swimming = new Swimming("05 May 2024", 55, 15);
        Cycling cycling = new Cycling("1 June 2024", 45, 27);

        // Creating a list to store the activities
        List<Activity> activities = new List<Activity>();

        // Adding activities to the list
        activities.Add(running);
        activities.Add(swimming);
        activities.Add(cycling);

        // Iterating through each activity in the list
        foreach (Activity activity in activities)
        {
            // Calling the GetSummary method to display activity details
            activity.GetSummary();
        }
    }
}
