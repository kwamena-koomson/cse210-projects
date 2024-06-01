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
        double shippingCost = _customer.isFromUSA() ? 5 : 35; // If customer is from USA, shipping cost is $5, otherwise $35
        return shippingCost;
    }

    // Method to calculate the total price of the order
    public double CalculateTotalPrice()
    {
        double totalprice = 0; // Initialize total price

        // Calculate total price of products in the order
        foreach (Product p in _products) 
        {
            double price = p.CalculatePrice(); // Calculate price of each product
            totalprice += price; // Add product price to total price
        }

        double shippingCost = CalculateShipping(); // Calculate shipping cost
        totalprice += shippingCost; // Add shipping cost to total price
        return totalprice; // Return the total price
    }

    // Method to generate a packing label for the order
    public string GeneratePackingLabel()
    {
        string packingLabel = "Packing Label:\n"; // Initialize packing label string
        foreach (Product p in _products) 
        {
            packingLabel += p.GetName() + " - " + p.GetProductID() + "\n"; // Add product name and ID to the packing label
        }
        return packingLabel; // Return the packing label
    }

    // Method to generate a shipping label for the order
    public string GenerateShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n"; // Initialize shipping label string
        shippingLabel += _customer.GetName() + "\n" + _customer.GenerateAddress(); // Add customer name and address to the shipping label
        return shippingLabel; // Return the shipping label
    }

    // Method to generate a string representing the total cost of the order
    public string GenerateTotalCost()
    {
        string totalCost = "\nProducts:\n"; // Initialize total cost string
        double totalPrice = CalculateTotalPrice(); // Calculate total price of the order
        foreach (Product p in _products) 
        {
            // Add details of each product to the total cost string
            totalCost += p.GetName() + " (" + p.GetProductID() + ") - " + "$" + p.GetPrice() + " x " + p.GetQuantity() + " = " + p.CalculatePrice() + "\n";
        }
        
        totalCost += "Shipping Cost: $" + CalculateShipping() + "\n"; // Add shipping cost to the total cost string
        totalCost += "Total: $" + CalculateTotalPrice(); // Add total price to the total cost string
        
        return totalCost; // Return the total cost string
    }

    // Method to display the results of the order (packing label, shipping label, and total cost)
    public void DisplayResults()
    {
        string packingLabel = GeneratePackingLabel(); // Generate packing label
        string shippingLabel = GenerateShippingLabel(); // Generate shipping label
        string totalCost = GenerateTotalCost(); // Generate total cost string

        Console.WriteLine(packingLabel); // Display packing label
        Console.WriteLine(shippingLabel); // Display shipping label
        Console.WriteLine(totalCost); // Display total cost
    }
}
