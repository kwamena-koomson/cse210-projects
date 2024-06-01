using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address()
    {

    }

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public bool IsInternational()
    {
        bool isInternational = true;
        if(_country.ToLower() == "usa")
        {
            isInternational = false;
            return isInternational;
        } else {
            return isInternational;
        }
    }

    public string GetAddress()
    {
        string address = $"{_street}, {_city}, {_stateOrProvince}, {_country.ToUpper()}";
        return address;
    }
}