using System;

class Program
{
    static void Main(string[] args)
    {

        Address address1 = new Address(
            "123 Main Street",
            "Phoenix",
            "Arizona",
            "USA");

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Keyboard", "KB101", 45.99, 1));
        order1.AddProduct(new Product("Mouse", "MS205", 19.99, 2));
        order1.AddProduct(new Product("Monitor", "MN330", 179.99, 1));


        Address address2 = new Address(
            "55 King Street",
            "Toronto",
            "Ontario",
            "Canada");

        Customer customer2 = new Customer("Emily Brown", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Laptop", "LP450", 799.99, 1));
        order2.AddProduct(new Product("Headphones", "HP200", 59.99, 1));
        order2.AddProduct(new Product("Webcam", "WC150", 39.99, 2));

        //Order 1
        Console.WriteLine("ORDER 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}");

        Console.WriteLine();

        //Order 2
        Console.WriteLine("ORDER 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
    }
}