using System;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Online Ordering Program\n");
    }

    // First order: USA customer
    Address usaAddress = new Address(
        "123 Main Street",
        "Boise",
        "Idaho",
        "USA"
    );

    Customer usaCustomer = new Customer("Maria Silva, usaAddress");

    Order usaOrder = new Order(usaCustomer);

    usaOrder.AddProduct(new Product("Laptop", "P100", 899.99m, 1));
usaOrder.AddProduct(new Product("Wireless Mouse", "P101", 24.50m, 2));
usaOrder.AddProduct(new Product("Keyboard", "P102", 45.00m, 1));

// Second order: international customer
Address internationalAddress = new Address(
    "45 Avenida Julius Nyerere",
    "Maputo",
    "Maputo City",
    "Mozambique");

    Customer internationalCustomer = new Customer("Carlos Mbanze", internationalAddress);

    Order internationalOrder = new Order(internationalCustomer);

    internationalOrder.AddProduct(new Product("Headphones", "P200", 60.00m, 1));
internationalOrder.AddProduct(new Product("USB Cable", "P201", 8.50m, 3));
internationalOrder.AddProduct(new Product("Phone Stand", "P202", 15.25m, 1));

// Display both orders
DisplayOrder(usaOrder, "ORDER 1");
    DisplayOrder(internationalOrder, "ORDER 2");

    static void DisplayOrder(Order order, string orderName)
    {
        Console.WriteLine($"========== {orderName} ==========");

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine($"\nTotal Price: ${order.GetTotalCost():F2}");
        Console.WriteLine();
    }
}