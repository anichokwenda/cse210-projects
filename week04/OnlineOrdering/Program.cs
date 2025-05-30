using System;
class Program
{
    static void Main()
    {
        // Create addresses
        Address address1 = new Address("5 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("266 Bernard Ave", "Town", "ON", "AFRICA");

        // Create customers
        Customer customer1 = new Customer("Spencer Drake", address1);
        Customer customer2 = new Customer("Susan Mark", address2);

        // Create products
        Product product1 = new Product("Laptop", "A123", 10.99m, 2);
        Product product2 = new Product("Television", "B456", 19.99m, 3);
        Product product3 = new Product("Speaker", "C789", 5.99m, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order information
        Console.WriteLine("\nOrder 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.CalculateTotalPrice());

        Console.WriteLine("\nOrder 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.CalculateTotalPrice());
    }
}


