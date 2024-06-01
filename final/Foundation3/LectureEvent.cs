public class LectureEvent : Event
{   
    // Private member variables to hold the speaker and capacity details
    private string _speaker;
    private string _capacity;

    // Constructor to initialize the lecture event details
    public LectureEvent(string eventType, string eventTitle, string description, string date, string time, Address address, string speaker, string capacity)
        : base(eventType, eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // Override the FullDetails method to include speaker and capacity details
    public override string FullDetails()
    {
        // Get the base event details
        string eventDetails = base.FullDetails();
        // Replace "Standard Event Details" with "Full Event Details"
        eventDetails = eventDetails.Replace("Standard Event Details:\n", "Full Event Details:\n");
        // Add speaker and capacity details to the event details
        return $"{eventDetails}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}
