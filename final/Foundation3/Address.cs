public class Address
{
    // Private member variables to hold the address details
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    // Constructor to initialize the address details
    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // Method to return the formatted address details as a string
    public string GetAddressDetails()
    {
        return $"Street: {_streetAddress}\n" +
               $"City: {_city}\n" +
               $"State/Province: {_stateProvince}\n" +
               $"Country: {_country}";
    }
}
