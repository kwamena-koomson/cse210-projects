public class OutdoorEvent : Event
{   
    // Private member variable to hold the weather forecast details
    private string _weatherForecast;
    
    // Constructor to initialize the outdoor event details
    public OutdoorEvent(string eventType, string eventTitle, string description, string date, string time, Address address, string weatherForecast)
        : base(eventType, eventTitle, description, date, time, address)
    {
        // Initialize the weather forecast
        _weatherForecast = weatherForecast;
    }

    // Override the FullDetails method to include weather forecast details
    public override string FullDetails()
    {
        // Get the base event details
        string eventDetails = base.FullDetails();
        // Replace "Standard Event Details" with "Full Event Details"
        eventDetails = eventDetails.Replace("Standard Event Details:\n", "Full Event Details:\n");
        // Add weather forecast details to the event details
        return $"{eventDetails}\nWeather Forecast: {_weatherForecast}";
    } 
}
