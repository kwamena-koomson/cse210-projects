using System;

public class Product
{
    private string _name; // Name of the product
    private string _productID; // ID of the product
    private double _price; // Price per unit of the product
    private int _quantity; // Quantity of the product

    // Constructor to initialize a product with its name, ID, price, and quantity
    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    // Method to calculate the total price of the product (price per unit * quantity)
    public double CalculatePrice()
    {
        return _price * _quantity; // Return the total price of the product
    }

    // Method to get the name of the product
    public string GetName()
    {
        return _name; // Return the name of the product
    }

    // Method to get the ID of the product
    public string GetProductID()
    {
        return _productID; // Return the ID of the product
    }

    // Method to get the price per unit of the product
    public double GetPrice()
    {
        return _price; // Return the price per unit of the product
    }

    // Method to get the quantity of the product
    public int GetQuantity()
    {
        return _quantity; // Return the quantity of the product
    }
}
