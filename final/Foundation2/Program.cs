using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = [];

        Address address1 = new("Israel", "Jewish planes", "Nazareth", "Fisherman's street");
        Customer customer1 = new("Saint Peter", address1);
        Order order1 = new();

        order1.SetCustomer(customer1);
        order1.AddProduct(new Product(1, "Fisherman's net", 3.33f, 1));
        order1.AddProduct(new Product(2, "Fisherman's hooks", 0.01f, 7));
        orders.Add(order1);

        Address address2 = new("US", "California", "Los Angeles", "Silicon street");
        Customer customer2 = new("John Doe", address2);
        Order order2 = new();

        order2.SetCustomer(customer2);
        order2.AddProduct(new Product(3, "PC", 1111.1f, 1));
        order2.AddProduct(new Product(4, "HD monitor", 555.5f, 2));
        orders.Add(order2);

        Console.WriteLine("Orders:");

        foreach(Order order in orders)
        {
            Console.WriteLine();
            Console.WriteLine("Packing Label: " + order.GetPackingLabel());
            Console.WriteLine("Shipping Label: " + order.GetShippingLabel());
            Console.WriteLine("Total Cost: $" + Math.Round(order.GetTotalCost(), 2));
        }
    }
}