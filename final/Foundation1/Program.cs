using System;
using System.Collections.Generic;

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Length { get; set; }
    public List<string> Comments { get; }

    public Video(string title, string author, string length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<string>();
    }

    public void AddComment(string commenter, string comment)
    {
        Comments.Add($"[{commenter}]: {comment}");
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine(comment);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Understanding Python's Logical Operators", "Python Master", "302");
        video1.AddComment("@PythonFan123", "Great explanation!");
        video1.AddComment("@Coder123", "I understood it better now, thanks!");
        video1.AddComment("@CodeNewbie", "Could you make a video on loops next?");

        Video video2 = new Video("Mastering Game Jams in Unity", "UnityPro", "541");
        video2.AddComment("@UnityFanatic", "Really helpful video, thanks!");
        video2.AddComment("@GameDevGuru", "I've been waiting for this!");
        video2.AddComment("@CodeMaster", "Can't wait to try this out!");

        Video video3 = new Video("Mathematics in Animation Explained", "AnimationGuru", "842");
        video3.AddComment("@Animator101", "This blew my mind!");
        video3.AddComment("@MathGeek", "Amazing combination of animation and math!");
        video3.AddComment("@ArtLover", "This is why I love animation!");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}
