using System;

class Program
{
    static void Main(string[] args)
    {
        //  Order 1 
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P1001", 850.00, 1));
        order1.AddProduct(new Product("Wireless Mouse", "P1002", 25.00, 2));
        order1.AddProduct(new Product("Laptop Bag", "P1003", 40.00, 1));

        //  Order 2 
        Address address2 = new Address(
            "45 Admiralty Way",
            "Port Harcourt",
            "Rivers",
            "Nigeria"
        );

        Customer customer2 = new Customer("Mary Johnson", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Notebook", "P2001", 5.00, 4));
        order2.AddProduct(new Product("Pen Set", "P2002", 3.50, 3));
        order2.AddProduct(new Product("Backpack", "P2003", 30.00, 1));

        //  Display Order 1 
        Console.WriteLine("ORDER 1");
        Console.WriteLine();

        Console.WriteLine("Packing Label");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");

        Console.WriteLine();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine();

        //  Display Order 2 
        Console.WriteLine("ORDER 2");
        Console.WriteLine();

        Console.WriteLine("Packing Label");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}