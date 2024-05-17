using System;

class Activity
{
  // Activity details
  private readonly string _name;
  private readonly string _description;
  private int _duration;
  private readonly ConsoleHelper _console;
  private readonly Random _rnd;

  // Constructor
  public Activity(string name, string description, int duration = 0)
  {
    _name = name;
    _description = description;
    _duration = duration;

    _console = new ConsoleHelper(); 
    _rnd = new Random();
  }

  // Method to start activity
  public void Run()
  {
    DisplayStartingMessage(); 
    int seconds = _console.GetIntFromUser("How long in seconds, would you like for your session? ", 3600); // an hour maximum
    _duration = seconds;

    Console.Clear();
    Console.WriteLine("Get ready...");
    ShowSpinner(); 

    RunActivityLogic(); 

    DisplayEndingMessage(); 
  }

  // Method to run activity-specific logic (to be overridden)
  public virtual void RunActivityLogic()
  {
    /* 
      Will be overwritten in other classes 
    */
  }

  // Method to display starting message
  private void DisplayStartingMessage()
  {
    Console.Clear();
    Console.WriteLine($"Welcome to the {_name} Activity.\n\n{_description}\n");
  }

  // Method to display ending message
  private void DisplayEndingMessage()
  {
    Console.WriteLine("\nWell done!!");
    ShowSpinner();
    Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
    ShowSpinner();
  }

  // Method to display a spinner animation
  protected void ShowSpinner(int seconds = 5)
  {
    char[] spinner = new char[]
    {
      '|',
      '/',
      '-',
      '\\',
      '|',
      '/',
      '-',
      '\\'
    };
    double animTimeStep = 0.5; // in seconds
    double remainSeconds = seconds;

    while (remainSeconds > 0)
    {
      foreach (char s in spinner)
      {
        Console.Write(s);
        Thread.Sleep((int)(animTimeStep * 1000));
        Console.Write("\b \b");

        remainSeconds -= animTimeStep;
        if (remainSeconds == 0)
        {
          break;
        }
      }
    }
  }

  // Method to display a countdown
  protected void ShowCountDown(int seconds)
  {
    for (int i = seconds; i > 0; i--)
    {
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }
  }

  // Method to get activity name
  public string GetName()
  {
    return _name;
  }

  // Method to get activity duration
  protected int GetDuration()
  {
    return _duration;
  }

  // Method to get a random prompt from a list
  protected string GetRandomPrompt(List<string> prompts)
  {
    int r = _rnd.Next(prompts.Count);

    return prompts[r];
  }
}