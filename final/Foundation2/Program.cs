using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address addressGhana = new Address("14 Ring Road Central", "Accra", "Greater Accra Region", "Ghana"); 
        Customer customer1 = new Customer("Kwamena Koomson", address1); 
        List<Product> productsList1 = new List<Product>(); 

        // Creating product objects for order 1
        Product product1 = new Product("Wireless Mouse", "WM100", 19.99, 3);
        Product product2 = new Product("Bluetooth Earphones", "BE200", 49.99, 1);
        Product product3 = new Product("USB Flash Drive", "USB32", 12.99, 2);

        // Adding products to the product list for order 1
        productsList1.Add(p1001);
        productsList1.Add(p1002);
        productsList1.Add(p1003);

        // Creating an order object for order 1 with the provided products and customer
        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults(); // Displaying the results of order 1
        Console.WriteLine();

        // Order 2
        Address address2 = new Address("123 Main St", "Anytown", "CA", "USA"); 
        Customer customer2 = new Customer("Obedient A. Ankrah", address2); 
        List<Product> productsList2 = new List<Product>(); 

        // Creating product objects for order 2
        Product p2001 = new Product("Highlighter Set", "HLSET", 4.99, 3);
        Product p2002 = new Product("Index Cards", "IC100", 1.75, 2);
        Product p2003 = new Product("Scientific Calculator", "SCC1000", 12.50, 1);

        // Adding products to the product list for order 2
        productsList2.Add(p2001);
        productsList2.Add(p2002);
        productsList2.Add(p2003);

        // Creating an order object for order 2 with the provided products and customer
        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults(); // Displaying the results of order 2
        Console.WriteLine();

        // Order 3
        Address address3 = new Address("Kungsgatan 1", "Stockholm", "SE-111 43", "Sweden"); 
        Customer customer3 = new Customer("Eric Boateng", address3); 
        List<Product> productsList3 = new List<Product>(); 

        // Creating product objects for order 3
        Product p3001 = new Product("Backpack", "BP300", 19.99, 1);
        Product p3002 = new Product("Laptop Sleeve", "LS100", 12.50, 2);
        Product p3003 = new Product("Sticky Notes", "SN500", 2.49, 5);


        // Adding products to the product list for order 3
        productsList3.Add(p3001);
        productsList3.Add(p3002);
        productsList3.Add(p3003);

        // Creating an order object for order 3 with the provided products and customer
        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order Number: 3");
        order3.DisplayResults(); 
        Console.WriteLine();
    }
}
