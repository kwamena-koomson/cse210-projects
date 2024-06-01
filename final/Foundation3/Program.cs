using System;

class Program
{
    static void Main(string[] args)
    {
        LectureEvent lectureEvent = new LectureEvent("Harry Potter 5", "Come and hear the words of this magic adventure", "07/23/2023", "18:00h", "J.K Rowling", 30);
        lectureEvent.SetAddress("116 W Main St", "West Branch", "Idaho", "USA");

        lectureEvent.DisplayFullDetails();
        lectureEvent.DisplayShortDption();
        lectureEvent.DisplayStandardDetails();

        OutdoorEvent outdoorEvent = new OutdoorEvent("Latin Festival", "Bienvenidos a Latino Gang Fest, the place where all latin music lovers come together to vibe!", "07/14/2023", "20:00h", "Sunny");
        outdoorEvent.SetAddress("Florianweg 20", "Warburg", "North Rhine-Westphalia", "DE");

        outdoorEvent.DisplayFullDetails();
        outdoorEvent.DisplayShortDption();
        outdoorEvent.DisplayStandardDetails();

        ReceptionEvent receptionEvent = new ReceptionEvent("Wedding Jane & Joe", "Celebrate with us our marriage", "07/10/2023", "19:00h", "jane33352@mahmul.com");
        receptionEvent.SetAddress("29 South St", "Epsom", "Surrey", "UK");

        receptionEvent.DisplayFullDetails();
        receptionEvent.DisplayShortDption();
        receptionEvent.DisplayStandardDetails();

    }
}