// Showed creativity and exceeded the core requirements by adding the ability to auto-save

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Program
{
    private static List<Goal> goals = new List<Goal>();
    private static int userScore = 0;

    public static void Main(string[] args)
    {
        bool running = true;
        bool AutoSave = false;
        string autoSaveFilePath = "Goals.csv";
        while (running)
        {
            // Display the user's score.
            Console.WriteLine();
            DisplayScore();
            Console.WriteLine();
            // Display the program menu.
            DisplayMenu();
            string choice = Console.ReadLine();
            // Process user choice.
            switch (choice)
            {
                case "1":
                    // Create a new goal.
                    CreateGoal();
                    // Auto-save if enabled.
                    if (AutoSave)
                    {
                        ExportGoalsToCSV(autoSaveFilePath);
                    }
                    break;
                case "2":
                    // View existing goals.
                    ViewGoals();
                    break;
                case "3":
                    // Save goals to a CSV file.
                    Console.WriteLine("Please input the file path where you want to save the CSV file:");
                    string filePath = Console.ReadLine();
                    ExportGoalsToCSV(filePath);
                    
                    break;
                case "4":
                    // Load goals from a CSV file.
                    ImportGoalsFromCSV();
                    break;
                case "5":
                    // Record achievement for a goal.
                    RecordGoalAchievement();
                    // Auto-save if enabled.
                    if (AutoSave)
                    {
                        ExportGoalsToCSV(autoSaveFilePath);
                    }
                    break;
                case "6":
                    // Toggle auto-save feature.
                    AutoSave = !AutoSave;
                    Console.WriteLine($"Auto-Save is now {(AutoSave ? "enabled" : "disabled")}.");
                    if (AutoSave)
                    {
                        Console.WriteLine("Please provide the file name for saving the CSV:");
                        autoSaveFilePath = Console.ReadLine();
                        ExportGoalsToCSV(autoSaveFilePath);
                    }
                    break;
                case "7":
                    // Exit the program.
                    running = false;
                    if (AutoSave)
                    {
                        ExportGoalsToCSV(autoSaveFilePath);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please choose a valid option.");
                    break;
            }
        }
    }

    // Display the program menu.
    private static void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Eternal Quest Program!");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals to CSV");
        Console.WriteLine("4. Load Goals from CSV");
        Console.WriteLine("5. Record Goal Achievement");
        Console.WriteLine("6. Toggle Auto-Save");
        Console.WriteLine("7. Quit");
        Console.Write("Select an option: ");
    }

// Method to create a new goal based on user input.
private static void CreateGoal()
{
    // Prompt user to select goal type and provide details.
    Console.Write("Select goal type (1. Simple, 2. Eternal, 3. Checklist):");
    string type = Console.ReadLine();
    Console.Write("Please enter the name of the goal:");
    string name = Console.ReadLine();
    Console.Write("Provide a brief description for the goal:");
    string description = Console.ReadLine();
    Console.Write("Specify the point value for the goal:");
    int pointValue = int.Parse(Console.ReadLine());
    
    // Create goal based on selected type.
    switch (type)
    {
        case "1":
            goals.Add(new SimpleGoal(name, pointValue, description));
            break;
        case "2":
            goals.Add(new EternalGoal(name, pointValue, description));
            break;
        case "3":
            Console.WriteLine("Specify the completion target for the checklist goal:");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("Specify the bonus points for the checklist goal:");
            int bonusPoints = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(name, pointValue, target, bonusPoints, description));
            break;
        default:
            Console.WriteLine("Invalid goal type.");
            break;
    }
    Console.WriteLine("Goal has been created successfully.");
}
// Method to record achievement for a selected goal.
private static void RecordGoalAchievement()
{
    // Check if there are any goals available
    if (goals.Count == 0)
    {
        Console.WriteLine("No goals available.");
        return;
    }

    // Display available goals for selection.
    Console.WriteLine("Select a goal to record achievement:");
    for (int i = 0; i < goals.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {goals[i].Name} - {goals[i].Description}");
    }
    Console.Write("Enter goal number:");

    // Read user input for selected goal.
    if (!int.TryParse(Console.ReadLine(), out int goalNumber) || goalNumber < 1 || goalNumber > goals.Count)
    {
        Console.WriteLine("Invalid selection.");
        return;
    }
    // Retrieve selected goal.
    var goal = goals[goalNumber - 1];
    // Record achievement based on goal type
    if (goal is EternalGoal eternalGoal)
    {
        eternalGoal.RecordOccurrence();
    }
    else if (goal is ChecklistGoal checklistGoal)
    {
        checklistGoal.RecordCompletion();
    }
    else
    {
        goal.MarkAsComplete();
    }
    Console.WriteLine($"Achievement recorded for goal: {goal.Name}");
}
// Method to display all existing goals.
private static void ViewGoals()
{
    int goalNumber = 1;
    foreach (var goal in goals)
    {
        if (goal is EternalGoal eternalGoal)
        {
            Console.WriteLine($"{goalNumber}. [ ]{goal.Name} ({goal.Description}) - Goal Count: {eternalGoal.Occurrences}");
        }
        else if (goal is ChecklistGoal checklistGoal)
        {
            if (goal.IsCompleted)
                Console.WriteLine($"{goalNumber}. [X]{goal.Name} ({goal.Description}) - Completion Count: {checklistGoal.CompletionCount}/{checklistGoal.CompletionTarget}");
            else
                Console.WriteLine($"{goalNumber}. [ ]{goal.Name} ({goal.Description}) - Completion Count: {checklistGoal.CompletionCount}/{checklistGoal.CompletionTarget}");
        }
        else
        {
            if (goal.IsCompleted)
                Console.WriteLine($"{goalNumber}. [X]{goal.Name} ({goal.Description})");
            else
                Console.WriteLine($"{goalNumber}. [ ]{goal.Name} ({goal.Description})");
        }
        goalNumber++;
    }
}
// Method to display the user's total score.
private static void DisplayScore()
{
    userScore = goals.Sum(g => g.CalculateScore());
    Console.WriteLine($"Your total score is: {userScore}");
}
// Method to export goals to a CSV file.
private static void ExportGoalsToCSV(string filePath)
{
    StringBuilder csvContent = new StringBuilder();
    csvContent.AppendLine("Goal Name,Description,Point Value,Is Completed,Score,Goal Type,Completion Count,Completion Target,Bonus Points");

    // Loop through each goal and format its data for CSV export.
    foreach (var goal in goals)
    {
        string line = $"\"{goal.Name}\",\"{goal.Description}\",{goal.PointValue},{goal.IsCompleted},{goal.CalculateScore()}";
        string goalType;
        string additionalData = "";

        if (goal is SimpleGoal)
        {
            goalType = "SimpleGoal";
            additionalData = ",,,";
        }
        else if (goal is EternalGoal eternalGoal)
        {
            goalType = "EternalGoal";
            additionalData = $",{eternalGoal.Occurrences},,";
        }
        else if (goal is ChecklistGoal checklistGoal)
        {
            goalType = "ChecklistGoal";
            additionalData = $",{checklistGoal.CompletionCount},{checklistGoal.CompletionTarget},{checklistGoal.BonusPoints}";
        }
        else
        {
            goalType = "Unknown";
        }

        line += $",{goalType}{additionalData}";
        csvContent.AppendLine(line);
    }

    // Write CSV content to the specified file path.
    File.WriteAllText(filePath, csvContent.ToString());
    Console.WriteLine("Goals exported to CSV file successfully.");
}



// Method to import goals from a CSV file.
private static void ImportGoalsFromCSV()
{
    Console.WriteLine("Provide the file path to import the CSV:");
    string filePath = Console.ReadLine();

    if (!File.Exists(filePath))
    {
        Console.WriteLine("File not found.");
        return;
    }
    // Read all lines from the CSV file.
    var lines = File.ReadAllLines(filePath);
    foreach (string line in lines.Skip(1))
    {
        var data = line.Split(',');

        if (data.Length < 9) 
        {
            Console.WriteLine("The CSV file has an invalid data format.");
            continue;
        }

        // Extract goal data from CSV.
        string name = data[0].Trim('\"');
        string description = data[1].Trim('\"'); 
        int pointValue = int.Parse(data[2]);
        bool isCompleted = bool.Parse(data[3]);
        string goalType = data[5];

        Goal goal;
        switch (goalType)
        {
            case "SimpleGoal":
                goal = new SimpleGoal(name, pointValue, description);
                break;
            case "EternalGoal":
                int occurrences = int.Parse(data[6]);
                var eternalGoal = new EternalGoal(name, pointValue, description);
                for (int i = 0; i < occurrences; i++)
                {
                    eternalGoal.RecordOccurrence();
                }
                goal = eternalGoal;
                break;
            case "ChecklistGoal":
                int completionCount = int.Parse(data[6]);
                int completionTarget = int.Parse(data[7]);
                int bonusPoints = int.Parse(data[8]);
                var checklistGoal = new ChecklistGoal(name, pointValue, completionTarget, bonusPoints, description);
                for (int i = 0; i < completionCount; i++)
                {
                    checklistGoal.RecordCompletion();
                }
                goal = checklistGoal;
                break;
            default:
                Console.WriteLine($"Invalid goal type: {goalType}");
                continue;
        }

        if (isCompleted && goal is not EternalGoal)
        {
            goal.MarkAsComplete();
        }
        goals.Add(goal);
    }

    Console.WriteLine("Goals have been imported from CSV file successfully.");
}

}