using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videosList = new List<Video>();

        // Video 1
        Video video1 = new Video("Hiking the Trails: Exploring Nature's Wonders", "Maria Rodriguez", 720);

        Comment video1Comment1 = new Comment("John", "This video captures the essence of nature perfectly. I felt like I was hiking alongside you!");
        Comment video1Comment2 = new Comment("Emily", "Your passion for the outdoors is truly inspiring. I can't wait to go on my own hiking adventure!");
        Comment video1Comment3 = new Comment("David", "Absolutely breathtaking views! Keep up the great work in showcasing the beauty of our natural world.");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videosList.Add(video1);

        // Video 2
        Video video2 = new Video("Discovering Ghana: A Journey through Culture and History", "Kwame Asante", 720);

        Comment video2Comment1 = new Comment("Akua", "Your exploration of Ghana's culture and history is truly enlightening. I'm proud to call Ghana my home.");
        Comment video2Comment2 = new Comment("Kwesi", "Thank you for showcasing the beauty of Ghana. Your videos inspire me to explore more of our rich heritage.");
        Comment video2Comment3 = new Comment("Ama", "I'm amazed by the diversity and richness of Ghana's culture. Keep up the great work!");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videosList.Add(video2);

        // Video 3
        Video video3 = new Video("Unboxing the iPhone 15 Pro Max: Next-Generation Technology", "Sarah Johnson", 480);

        Comment video3Comment1 = new Comment("Michael", "I've been eagerly waiting for this unboxing video! The iPhone 15 Pro Max seems like an incredible device.");
        Comment video3Comment2 = new Comment("Emma", "Your unboxing videos are always so detailed and informative. Can't wait to get my hands on the iPhone 15 Pro Max!");
        Comment video3Comment3 = new Comment("David", "Apple never fails to impress with their new releases. Your video has me excited to upgrade to the iPhone 15 Pro Max!");

        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);

        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}