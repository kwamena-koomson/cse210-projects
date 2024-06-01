using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer()
    {

    }

    public Customer(string name)
    {
        _name = name;
    }

    public string DisplayName()
    {
        return _name;
    }

    public void SetAddress(string street, string city, string stateOrProvince, string country)
    {
        _address = new Address(street, city, stateOrProvince, country);
    }

    public string DisplayAddress()
    {
        return _address.GetAddress();
    }

    public bool GetInternational()
    {
        return _address.IsInternational();  
    }
    
}