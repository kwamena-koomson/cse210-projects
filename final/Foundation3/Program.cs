using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("789 Maple Street", "Portland", "Oregon", "USA");
        Address address2 = new Address("234 Elm Street", "Savannah", "Georgia", "USA");
        Address address3 = new Address("321 Pine Road", "Boulder", "Colorado", "USA");

        LectureEvent lecture = new LectureEvent("Lecture", "Exploring Quantum Computing", "Join us for an in-depth exploration of the principles and applications of quantum computing technology.", "2023-07-20", "19:00", address1, "Dr. Maria Rodriguez", "50");
        ReceptionEvent reception = new ReceptionEvent("Reception", "Tech Industry Networking Mixer", "A networking event for professionals in the tech industry to connect and collaborate.", "2023-08-10", "18:30", address2, "technetworking@gmail.com");
        OutdoorEvent outdoor = new OutdoorEvent("Outdoor", "Beach Cleanup Day", "Join us for a community beach cleanup event to preserve our coastal environment.", "2023-08-05", "09:00", address3, "Sunny with a gentle breeze. Perfect weather for outdoor activities!");
   
        Console.WriteLine("Lecture Event:");
        Console.WriteLine();
        Console.WriteLine(lecture.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.ShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception Event:");
        Console.WriteLine();
        Console.WriteLine(reception.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.ShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Event:");
        Console.WriteLine();
        Console.WriteLine(outdoor.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.FullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.ShortDescription());
    }
   
}