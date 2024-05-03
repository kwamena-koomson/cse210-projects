using System;

public class JournalPrompt
{

    public static string[] _prompt = {
        "What food or drink made you happy today?",
            "What made you smile today?",
            "What was the most unexpected event of the day?",
            "Describe something that you achieved today.",
            "What inspired you today?",
            "Who did you help today, and how?",
            "What was the most beautiful thing you saw today?",
            "What song was stuck in your head today?",
            "If you could relive one moment from today, what would it be?",
            "What was the most challenging part of your day?",
            "Who surprised you today, and why?",
            "What is one thing you'd like to do differently tomorrow?",
            "What was the kindest act you experienced today?",
            "How did you take care of yourself today?",
            "What was your biggest 'aha' moment today?",
            "Who or what made you feel safe today?",
            "What problem did you solve today?",
            "What did you discover about yourself today?",
            "What is the one word that best describes today?",
            "What did you learn from a friend or colleague today?",
            "What made you feel energized today?",
            "How did you express creativity today?",
            "If you could change one thing about today, what would it be?",
            "What did you do today that you're proud of?",
            "What advice would you give your past self about today?",
            "How did you step out of your comfort zone today?",
            "Who did you meet today, and what did you talk about?",
            "What is something you look forward to tomorrow?",
            "What was the most rewarding part of your day?",
            "What is a skill you'd like to improve based on today's experiences?",
            "What was the most relaxing part of your day?",
            "What new thing did you try today?",
            "If you could spend more time with someone today, who would it be?",
            "What made you curious today?",
            "What is the most valuable lesson you learned today?",
            "Who made you laugh the hardest today?",
            "What was the most thoughtful thing you did for someone today?",
            "How did you manage stress today?",
            "What decision made you feel accomplished today?",
            "What did you appreciate about nature today?"
    };
    public List<string> _journalPrompt = new List<string>(_prompt);

    public JournalPrompt()
    {

    }

    public void Display()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        Console.WriteLine($"\n{_journalPrompt}");
    }

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        
        return journalPrompt;
    }
}