using System;
using System.Collections.Generic; 

public class Video 
{
    // Private fields to store video information
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>(); 

    // Constructor to initialize video properties
    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Method to add a comment to the video
    public void ListComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to count the number of comments on the video
    public int CountComments()
    {
        int count = _comments.Count; 
        return count;
    }

    // Method to display video information along with comments
    public void DisplayInfo()
    {
        // Display video title, author, and length
        Console.WriteLine($"Title: {_title} | Author: {_author} | Length: {_length} seconds");
        Console.WriteLine();
        
        // Get the count of comments
        int commentCount = CountComments();
        Console.WriteLine($"Number of comments: {commentCount}");
        
        // Display each comment associated with the video
        foreach (Comment comment in _comments)
        {
            comment.DisplayInfo(); 
        }    
    }
}
