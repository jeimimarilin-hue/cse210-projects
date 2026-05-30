using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        Product prod1 = new Product("Wireless Mouse", "M102", 15.50, 2);
        Product prod2 = new Product("Mechanical Keyboard", "K504", 45.00, 1);
        Product prod3 = new Product("USB-C Cable", "C910", 8.99, 3);

        order1.AddProduct(prod1);
        order1.AddProduct(prod2);
        order1.AddProduct(prod3);


        Address address2 = new Address("Via Roma 45", "Milán", "MI", "Italy");
        Customer customer2 = new Customer("Giulia Rossi", address2);
        Order order2 = new Order(customer2);

        Product prod4 = new Product("Gaming Monitor 24\"", "MON77", 180.00, 1);
        Product prod5 = new Product("HDMI 2.1 Cable", "H302", 12.50, 2);

        order2.AddProduct(prod4);
        order2.AddProduct(prod5);


        // Results
        
        Console.WriteLine("========================================");
        Console.WriteLine("               ORDER #1                 ");
        Console.WriteLine("========================================");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine();

        Console.WriteLine("========================================");
        Console.WriteLine("               ORDER #2                 ");
        Console.WriteLine("========================================");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}");
        Console.WriteLine("========================================");
    }
}