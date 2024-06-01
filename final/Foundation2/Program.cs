using System;

class Program
{
    static void Main(string[] args)
    {   
        Customer customer = new Customer("John Doe");
        customer.SetAddress("116 W Main St", "West Branch", "Idaho", "USA");

        Order order = new Order(customer);
        order.AddProduct("Iphone 14", "19853A", 888.0, 2);
        order.AddProduct("Vans Old School", "VA215O03N", 76.19, 1);
        order.AddProduct("Fitbit SmartWatch", "F12059", 106.59, 2);

        Console.Clear();
        order.DisplayPackingLabel();
        order.DisplayShippingLabel();
        order.DisplayTotalCost();

        Customer customer1 = new Customer("Jane Peters");
        customer1.SetAddress("Av Revolucion 721", "Tijuana", "Baja California", "MX");

        Order order1 = new Order(customer1);
        order1.AddProduct("Microwave Panasonic", "B005GSPVHS", 319.0, 1);
        order1.AddProduct("Cargo Wrangler Shorts", "B08RBHL3HW", 26.85, 4);
        order1.AddProduct("Drone with 1080P camera", "B0C5X5WMXN", 399.99, 1);

        Console.WriteLine("\nSecond Order");
        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
        order1.DisplayTotalCost();
    }
}