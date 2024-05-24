public class ChecklistGoal : Goal
{
    // Properties to store completion count, completion target, and bonus points
    public int CompletionCount { get; private set; }
    public int CompletionTarget { get; private set; }
    public int BonusPoints { get; private set; }

    public ChecklistGoal(string name, int pointValue, int target, int bonusPoints, string description)
        : base(name, pointValue, description)
    {
        CompletionCount = 0;
        CompletionTarget = target;
        BonusPoints = bonusPoints;
    }

    // Method to record completion of the checklist goal
    public void RecordCompletion()
    {
        // Increment completion count if it's less than the completion target
        if (CompletionCount < CompletionTarget)
        {
            CompletionCount++;
            if (CompletionCount == CompletionTarget)
            {
                MarkAsComplete();
            }
        }
    }

    public override int CalculateScore()
    {
        // If the goal is completed, return the sum of point value and bonus points
        if (IsCompleted)
        {
            return PointValue + BonusPoints;
        }
        else
        {
            return PointValue;
        }
    }
}
