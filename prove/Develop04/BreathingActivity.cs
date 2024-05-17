using System;

class BreathingActivity : Activity
{
  // Activity details
  private static readonly string _name = "Breathing";
  private static readonly string _description = "This activity will help you relax by guiding you to breathe in and out slowly. Clear your mind and concentrate on your breathing.";

  // Constructor
  public BreathingActivity(int duration = 0) : base(_name, _description, duration)
  {

  }

  // Method to run activity logic
  public override void RunActivityLogic()
  {
    // Initialization
    string inText = "\n\nBreathe in...";
    string outText = "\nNow breathe out...";
    int count;
    bool isBreatheIn = true; 
    int remainSeconds = base.GetDuration();

    // Display initial instructions
    Console.Write(inText);
    base.ShowCountDown(2);
    Console.Write(outText);
    base.ShowCountDown(3);
    remainSeconds -= 5;

    // Loop until time runs out
    while (remainSeconds > 0)
    {
      if (isBreatheIn)
      {
        Console.Write(inText);
        count = 4;
      }
      else
      {
        Console.Write(outText);
        count = 6;
      }
      base.ShowCountDown(count);
      remainSeconds -= count;

      isBreatheIn = !isBreatheIn;
    }

    Console.WriteLine();
  }
}