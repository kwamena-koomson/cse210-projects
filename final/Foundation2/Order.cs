using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(string name, string id, double price, int quantity)
    {
        _products.Add(new Product(name, id, price, quantity));
    }

    private int GetShippingCost()
    {
        int cost;
        if(_customer.GetInternational())
        {
            cost = 35;
        }
        else
        {
            cost = 5;
        }
        return cost;
    }

    public void DisplayPackingLabel()
    {   
        Console.WriteLine("Packing Label");
        Console.WriteLine("----------------------------");
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product name: {product.GetProductName()} Product id: {product.GetProductId()} Quantity: {product.GetQuantity()}");
        }
        Console.WriteLine("----------------------------");
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label");
        Console.WriteLine($"Customer: {_customer.DisplayName()}");Console.WriteLine($"To: {_customer.DisplayAddress()}");
    }

    private double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.ComputeTotalPrice();
        }

        totalCost += GetShippingCost();
        return totalCost;
    }

    public void DisplayTotalCost()
    {
        Console.WriteLine($"Order total cost: ${CalculateTotalCost()}");
    }
}