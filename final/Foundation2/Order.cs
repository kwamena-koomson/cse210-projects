using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products; // List to store products in the order
    private Customer _customer; // Customer associated with the order

    // Constructor to initialize an order with a list of products and a customer
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    // Method to calculate the shipping cost based on the customer's location
    public double CalculateShipping() 
    {
        double shippingCost = _customer.isFromUSA() ? 5 : 35; 
        return shippingCost;
    }

    // Method to calculate the total price of the order
    public double CalculateTotalPrice()
    {
        double totalprice = 0; 

        // Calculate total price of products in the order
        foreach (Product p in _products) 
        {
            double price = p.CalculatePrice(); // Calculate price of each product
            totalprice += price; // Add product price to total price
        }

        double shippingCost = CalculateShipping(); 
        totalprice += shippingCost; 
        return totalprice; 
    }

    // Method to generate a packing label for the order
    public string GeneratePackingLabel()
    {
        string packingLabel = "Packing Label:\n"; 
        foreach (Product p in _products) 
        {
            packingLabel += p.GetName() + " - " + p.GetProductID() + "\n"; 
        }
        return packingLabel; 
    }

    // Method to generate a shipping label for the order
    public string GenerateShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n"; 
        shippingLabel += _customer.GetName() + "\n" + _customer.GenerateAddress(); 
        return shippingLabel; 
    }

    // Method to generate a string representing the total cost of the order
    public string GenerateTotalCost()
    {
        string totalCost = "\nProducts:\n"; 
        double totalPrice = CalculateTotalPrice(); 
        foreach (Product p in _products) 
        {
            // Add details of each product to the total cost string
            totalCost += p.GetName() + " (" + p.GetProductID() + ") - " + "$" + p.GetPrice() + " x " + p.GetQuantity() + " = " + p.CalculatePrice() + "\n";
        }
        
        totalCost += "Shipping Cost: $" + CalculateShipping() + "\n"; 
        totalCost += "Total: $" + CalculateTotalPrice(); 
        
        return totalCost; // Return the total cost string
    }

    // Method to display the results of the order (packing label, shipping label, and total cost)
    public void DisplayResults()
    {
        string packingLabel = GeneratePackingLabel(); 
        string shippingLabel = GenerateShippingLabel(); 
        string totalCost = GenerateTotalCost(); 

        Console.WriteLine(packingLabel); 
        Console.WriteLine(shippingLabel); 
        Console.WriteLine(totalCost); 
    }
}
