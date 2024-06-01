using System;
using System.Collections.Generic; // Add the necessary namespace

// Assuming the Comment class is defined elsewhere

public class Video
{
    private string _title;
    private string _author;
    private string _videoLength;
    private List<Comment> _comments = new List<Comment>();

    public Video()
    {
        // Empty constructor
    }

    public Video(string title, string author, string videoLength)
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
    }

    public void AddComment(string name, string comment)
    {
        _comments.Add(new Comment(name, comment)); // Assuming Comment class is defined elsewhere
    }

    private int TrackTotalComments()
    {
        return _comments.Count;
    }

    private void DisplayComments()
    {
        int count = 1;
        foreach (Comment comment in _comments)
        {
            Console.Write($"{count}. ");
            comment.DisplayComment();
            count++;
        }
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Video title: {_title}, Author: {_author}, Length: {_videoLength} seconds, Number of Comments: {TrackTotalComments()}");
        Console.WriteLine("Comments:");
        DisplayComments();
    }
}
