using System;

public class Address
{
    // Member variables to store address components
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    // Default constructor
    public Address()
    {

    }

    // Parameterized constructor to initialize address components
    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    // Method to determine if the address is international based on country
    public bool IsInternational()
    {
        bool isInternational = true;
        if(_country.ToLower() == "usa") // Check if the country is USA
        {
            isInternational = false; // If USA, address is not international
            return isInternational;
        } else {
            return isInternational; // If not USA, address is international
        }
    }

    // Method to get the complete address as a formatted string
    public string GetAddress()
    {
        string address = $"{_street}, {_city}, {_stateOrProvince}, {_country.ToUpper()}";
        return address; // Return the formatted address string
    }
}
