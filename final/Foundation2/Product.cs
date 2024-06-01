using System;

public class Product
{
    // Private fields to store product information
    private string _name; // Product name
    private string _productID; // Product ID
    private double _price; // Product price
    private int _quantity; // Product quantity

    // Constructor to initialize product with name, ID, price, and quantity
    public Product(string name, string productID, double price, int quantity)
    {
        _name = name; 
        _productID = productID; 
        _price = price; 
        _quantity = quantity; 
    }

    // Method to calculate the total price of the product (price * quantity)
    public double CalculatePrice()
    {
        return _price * _quantity; 
    }

    // Method to get the name of the product
    public string GetName()
    {
        return _name; 
    }

    // Method to get the product ID
    public string GetProductID()
    {
        return _productID; 
    }

    // Method to get the price of the product
    public double GetPrice()
    {
        return _price; 
    }

    // Method to get the quantity of the product
    public int GetQuantity()
    {
        return _quantity; 
    }
}
