using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products; 
    private Customer _customer; 

    // Constructor to initialize the order with products and customer
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    // Method to calculate the shipping cost based on the customer's location
    public double CalculateShipping() 
    {
        // If customer is from the USA, set shipping cost to $5, otherwise set it to $35
        double shippingCost = _customer.isFromUSA() ? 5 : 35;
        return shippingCost;
    }

    // Method to calculate the total price of the order, including shipping cost
    public double CalculateTotalPrice()
    {
        double totalPrice = 0; 

        // Loop through each product in the order
        foreach (Product p in _products) 
        {
            double price = p.CalculatePrice(); 
            totalPrice += price; 
        }

        double shippingCost = CalculateShipping(); 
        totalPrice += shippingCost; 
        return totalPrice; 
    }

    // Method to generate a packing label for the order
    public string GeneratePackingLabel()
    {
        string packingLabel = "Packing Label:\n"; 
        foreach (Product p in _products) 
        {
            // Add product name and ID to the packing label
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

    // Method to generate the total cost breakdown of the order
    public string GenerateTotalCost()
    {
        string totalCost = "\nProducts:\n"; 
        double totalPrice = CalculateTotalPrice(); 
        foreach (Product p in _products) 
        {
            // Add each product's details to the total cost string
            totalCost += p.GetName() + " (" + p.GetProductID() + ") - " + "$" + p.GetPrice() + " x " + p.GetQuantity() + " = " + p.CalculatePrice() + "\n";
        }
        
        // Add shipping cost and total price to the total cost string
        totalCost += "Shipping Cost: $" + CalculateShipping() + "\n";
        totalCost += "Total: $" + CalculateTotalPrice();
        
        return totalCost; 
    }

    // Method to display the results of the order (packing label, shipping label, total cost)
    public void DisplayResults()
    {
        string packingLabel = GeneratePackingLabel(); 
        string shippingLabel = GenerateShippingLabel(); 
        string totalCost = GenerateTotalCost(); 

        // Display packing label, shipping label, and total cost
        Console.WriteLine(packingLabel);
        Console.WriteLine(shippingLabel);
        Console.WriteLine(totalCost);
    }
}
