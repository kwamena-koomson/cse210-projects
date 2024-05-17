using System;
using System.Collections.Generic;

// Activity class for listing prompts
class ListingActivity : Activity
{
    private static readonly string _name = "Listing";
    private static readonly string _description = "This activity will help you reflect on the positives in your life by having you list as many things as you can in a specific area.";
    private int _count;
    private readonly List<string> _prompts;

    // Constructor
    public ListingActivity(int duration = 0) : base(_name, _description, duration)
    {
        // Initializing prompts
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "When did you know that God loves you?",
            "When did you experience a profound spiritual connection or sense of divine presence in your life?",
            "How has your faith or spirituality provided comfort or guidance during difficult times in your life?"
        };
    }

    // Method to run activity logic
    public override void RunActivityLogic()
    {
        // Remaining duration calculation
        int remainSeconds = base.GetDuration();
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        DisplayPrompt(); 
        Console.Write("You may begin in: ");
        base.ShowCountDown(5);
        remainSeconds -= 5;

        Console.WriteLine(); 
        // Getting user responses
        List<string> userList = GetListFromUser(remainSeconds);
        _count = userList.Count;
        Console.Write($"You listed {_count} items!");
    }

    // Method to display prompt
    private void DisplayPrompt()
    {
        string prompt = base.GetRandomPrompt(_prompts);
        Console.WriteLine($" --- {prompt} --- ");
    }

    // Method to get responses from user
    private List<string> GetListFromUser(int remainSeconds)
    {
        string userAnswer;
        List<string> list = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(remainSeconds);

        // Loop until time ends
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            userAnswer = Console.ReadLine();
            list.Add(userAnswer);
        }

        return list;
    }
}
