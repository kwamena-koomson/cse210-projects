using System;

public class Comment
{
    private string _authorName;
    private string _commentText;

    public Comment()
    {

    }

    public Comment(string name, string comment)
    {
        _authorName = name;
        _commentText = comment;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"Comment Author: {_authorName}, Comment: {_commentText}");
    }
}