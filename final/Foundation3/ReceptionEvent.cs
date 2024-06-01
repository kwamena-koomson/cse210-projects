public class ReceptionEvent : Event
{   
    // Private field to store RSVP email
    private string _rsvpEmail;
    
    // Constructor to initialize ReceptionEvent object
    public ReceptionEvent(string eventType, string eventTitle, string description, string date, string time, Address address, string rsvpEmail): base(eventType, eventTitle, description, date, time, address)
    {
        // Initialize RSVP email
        _rsvpEmail = rsvpEmail;
    }
    
    // Override method to provide full details of the reception event
    public override string FullDetails()
    {
        // Get full details from the base class and replace the standard details label with "Full Event Details"
        string eventDetails = base.FullDetails();
        eventDetails = eventDetails.Replace("Standard Event Details:\n", "Full Event Details:\n");
        // Append RSVP email to the event details
        return $"{eventDetails}\nRSVP Email: {_rsvpEmail}";
    }  
}
