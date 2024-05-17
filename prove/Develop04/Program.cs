
/* 
  I ensured that no random questions are selected until each has been used at least once
  in that session. Additionally, I crafted a separate ConsoleHelper class to facilitate 
  obtaining integers from the user and displaying colored messages.
 */

using System;

class Program
{
  private static readonly ConsoleHelper _console = new ConsoleHelper(); 
  private static List<Activity> _activities; 

  static void Main(string[] args)
  {
    _activities = new List<Activity>() 
    {
      new BreathingActivity(),
      new ReflectingActivity(),
      new ListingActivity()
    };
    int quitOption = _activities.Count + 1;
    int chosenItem;

    do
    {
      PrintMenu(_activities); 
      chosenItem = _console.GetIntFromUser("Select a choice from the menu: ", quitOption); 

      if (chosenItem < quitOption)
      {
        // turn to index
        chosenItem--;
        Activity activity = _activities[chosenItem];
        activity.Run(); 
      }
    } while (chosenItem != quitOption);
  }

  // Method to print menu
  private static void PrintMenu(List<Activity> activities)
  {
    Console.Clear();
    Console.WriteLine("Menu Options:");
    for (int i = 1; i <= activities.Count; i++)
    {
      string activityName = activities[i - 1].GetName();
      Console.WriteLine($"  {i}. Start {activityName.ToLower()} activity");
    }
    Console.WriteLine($"  {activities.Count + 1}. Quit");
  }
}