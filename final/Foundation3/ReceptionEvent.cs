public class ReceptionEvent : Event
{   

    private string _rsvpEmail;
    

    public ReceptionEvent(string eventType, string eventTitle, string description, string date, string time, Address address, string rsvpEmail): base(eventType, eventTitle, description, date, time, address)
    {
        
        _rsvpEmail = rsvpEmail;
        
    }
    public override string FullDetails()
    {
        string eventDetails = base.FullDetails();
        eventDetails = eventDetails.Replace("Standard Event Details:\n", "Full Event Details:\n");
        return $"{eventDetails}\nRSVP Email: {_rsvpEmail}";
    }  
}