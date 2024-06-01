using System;

public class Comment
{
    private string _authorName;
    private string _commentText;

    // Default constructor
    public Comment()
    {
        // Empty constructor
    }

    // Parameterized constructor
    public Comment(string name, string comment)
    {
        _authorName = name;
        _commentText = comment;
    }

    // Method to display comment information
    public void DisplayComment()
    {
        Console.WriteLine($"Comment Author: {_authorName}, Comment: {_commentText}");
    }
}
