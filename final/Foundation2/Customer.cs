using System;

public class Customer
{
    // Member variables to store customer name and address
    private string _name;
    private Address _address;

    // Default constructor
    public Customer()
    {

    }

    // Parameterized constructor to initialize customer with name
    public Customer(string name)
    {
        _name = name;
    }

    // Method to get the customer's name
    public string DisplayName()
    {
        return _name;
    }

    // Method to set the customer's address
    public void SetAddress(string street, string city, string stateOrProvince, string country)
    {
        _address = new Address(street, city, stateOrProvince, country); 
    }

    // Method to get the formatted address of the customer
    public string DisplayAddress()
    {
        return _address.GetAddress(); 
    }

    // Method to check if the customer's address is international
    public bool GetInternational()
    {
        return _address.IsInternational(); 
    }
}
