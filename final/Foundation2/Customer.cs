using System;

public class Customer
{
    
    private string _name;
    private Address _address;

    // Constructor to initialize customer information
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to check if the customer's address is in the USA
    public bool isFromUSA()
    {
        // Check if the customer's address is in the USA using the Address class method
        return _address.isUSA() ? true : false;
    }
    
    // Method to get the customer's name
    public string GetName()
    {
        // Return the customer's name
        return _name;
    }

    // Method to generate the customer's address
    public string GenerateAddress()
    {
        // Generate the address using the Address class method and return it
        string generatedAddress = _address.GenerateAddress();
        return generatedAddress;
    }
}
