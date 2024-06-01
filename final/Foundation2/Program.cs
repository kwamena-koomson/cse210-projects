using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        // Create an address for the first customer
        Address address1 = new Address("Kinkum Ventures St 77", "Teshie", "Accra", "Ghana");
        Customer customer1 = new Customer("Kwamena Koomson", address1);
        
        List<Product> productsList1 = new List<Product>();
        Product p1001 = new Product("Usb drive", "GB400", 15.99, 1);
        Product p1002 = new Product("Notebook", "NC50", 13.50, 5);
        Product p1003 = new Product("Hand luggage", "GK05", 11.99, 10);

        productsList1.Add(p1001);
        productsList1.Add(p1002);
        productsList1.Add(p1003);

        // Create the first order with the products and customer
        Order order1 = new Order(productsList1, customer1);

        // Display the details of the first order
        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();

        // Order 2
        // Create an address for the second customer
        Address address2 = new Address("789 Elm St", "Springfield", "IL 62701", "USA");
        Customer customer2 = new Customer("Blake A. Larsen", address2);
        

        List<Product> productsList2 = new List<Product>();
        Product p2001 = new Product("Wireless Mouse", "WM123", 41.99, 3);
        Product p2002 = new Product("Bluetooth Speaker", "BTS456", 11.75, 2);
        Product p2003 = new Product("Calculator", "C1500", 2.50, 1);

        productsList2.Add(p2001);
        productsList2.Add(p2002);
        productsList2.Add(p2003);

        // Create the second order with the products and customer
        Order order2 = new Order(productsList2, customer2);

        // Display the details of the second order
        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();

        // Order 3
        // Create an address for the third customer
        Address address3 = new Address("789 Pine St", "Seattle", "WA 98101", "USA");
        Customer customer3 = new Customer("Emily R. Johnson", address3);
        

        List<Product> productsList3 = new List<Product>();
        Product p3001 = new Product("Water Bottle", "WB200", 18.99, 2);
        Product p3002 = new Product("Desk Lamp", "DL400", 41.99, 4);

        productsList3.Add(p3001);
        productsList3.Add(p3002);

        // Create the third order with the products and customer
        Order order3 = new Order(productsList3, customer3);

        // Display the details of the third order
        Console.WriteLine("Order Number: 3");
        order3.DisplayResults();
        Console.WriteLine();
    }
}
