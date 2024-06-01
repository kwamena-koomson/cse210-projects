using System;

public class Address
{
    // Private fields to store address components
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructor to initialize address components
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Method to check if the address is in the USA
    public bool isUSA()
    {
        // Check if the country is "USA" and return true, otherwise return false
        return _country == "USA" ? true : false;
    }

    // Method to generate a formatted address string
    public string GenerateAddress()
    {
        // Concatenate address components into a formatted string
        string address = _street + ", " + _city + "\n" + _state + ", " + _country;
        return address;
    }
}
