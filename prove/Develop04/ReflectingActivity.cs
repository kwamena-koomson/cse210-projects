
using System;

class ReflectingActivity : Activity
{
  // Activity details
  private static readonly string _name = "Reflecting";
  private static readonly string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
  private readonly List<string> _prompts;
  private readonly List<string> _questions;
  private List<int> _availableQuestions;
  private readonly Random _rnd;

  // Constructor
  public ReflectingActivity(int duration = 0) : base(_name, _description, duration)
  {
    // Initializing prompts and questions
    _prompts = new List<string>()
    {
      "Think of a time when you stood up for someone else.",
      "Think of a time when you did something really difficult.",
      "Think of a time when you helped someone in need.",
      "Think of a time when you did something truly selfless.",
      "Reflect on a time when you ventured beyond your comfort zone and experienced personal growth as a consequence.",
      "Consider a challenging task or project you took on and the insights gained from the experience."
    };
    _questions = new List<string>()
    {
      "Why was this experience meaningful to you?",
      "Have you ever done anything like this before?",
      "How did you get started?",
      "How did you feel when it was complete?",
      "What made this time different than other times when you were not as successful?",
      "What is your favorite thing about this experience?",
      "What could you learn from this experience that applies to other situations?",
      "What did you learn about yourself through this experience?",
      "How can you keep this experience in mind in the future?"
    };
    // Initializing available questions and random instance
    _availableQuestions = Enumerable.Range(0, _questions.Count).ToList();
    _rnd = new Random();
  }

  // Method to run activity logic
  public override void RunActivityLogic()
  {
    // Remaining duration calculation
    int remainSeconds = base.GetDuration();
    Console.WriteLine("\nConsider the following prompt:");
    DisplayPrompt(); // Displaying prompt
    Console.WriteLine("When you have something in mind, press enter to continue.");
    Console.ReadKey();

    Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
    Console.Write("You may begin in: ");
    base.ShowCountDown(5); // Countdown before starting
    remainSeconds -= 5;

    Console.Clear();
    DisplayQuestions(remainSeconds); // Displaying questions
    Console.WriteLine();
  }

  // Method to display prompt
  private void DisplayPrompt()
  {
    string prompt = base.GetRandomPrompt(_prompts);
    Console.WriteLine($"\n --- {prompt} --- \n");
  }

  // Method to display questions
  private void DisplayQuestions(int remainSec, int pauseSec = 10)
  {
    string question;
    while (remainSec > 0)
    {
      question = GetRandomQuestion(); 
      Console.Write($"\n> {question} ");
      pauseSec = remainSec >= pauseSec ? pauseSec : remainSec;
      base.ShowSpinner(pauseSec); 
      remainSec -= pauseSec;
    }
  }

  // Method to get a random question
  private string GetRandomQuestion()
  {
    if (_availableQuestions.Count == 0)
    {
      _availableQuestions = Enumerable.Range(0, _questions.Count).ToList();
    }

    int r = _rnd.Next(_prompts.Count);
    int i = _availableQuestions[r];
    _availableQuestions.RemoveAt(r);
    string randomQuestion = _questions[i];

    return randomQuestion;
  }
}