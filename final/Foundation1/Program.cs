using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("What are logical operators?", "Bro Code", "302");
        video1.AddComment("@LetsGoSalmon", "Hi! Are we getting any more C++ content this year?");
        video1.AddComment("@alfiemathias4710", "Very useful thanks");
        video1.AddComment("@karnprashantpk", "#include <love for BroCode>");

        Video video2 = new Video("HOW TO GAME JAM!", "Brackeys", "541");
        video2.AddComment("@Dorbellprod", "The worst part about game jams is that they often jam your brain.");
        video2.AddComment("@aruwaurachi9649", "Just starting using Unity, eager to be skilled enough to participate in a game jam ! :)");
        video2.AddComment("@nicholaswilliams6475", "I actually registered for my first game jam in July! This video is very helpful for my first time!");
        video2.AddComment("@LukeKondor", "Haven't done a Game Jam yet. I definitely want to give it a go, though. Looks terrifyingly fun.");

        Video video3 = new Video("Animation vs. Math", "Alan Becker", "842");
        video3.AddComment("@3blue1brown", "Utterly delightful!");
        video3.AddComment("@loop4967", "As a computer engineer, this must be the best animation I've ever seen.  Thank you for doing this!");
        video3.AddComment("@nothing91109", "To the math nerd that did the equation and to the animator, heavily respected");

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