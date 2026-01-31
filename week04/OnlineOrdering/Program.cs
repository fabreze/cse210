using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Customer customer1 = new Customer("John Doe", new Address("123 Main St", "Florida", "USA"));
        Customer customer2 = new Customer("Jane Doe", new Address("123 An Avenue", "Asuncion", "Paraguay"));

        List<Product> products1 = new List<Product>();
        products1.Add(new Product("Laptop", "LTP123", 999.99f, 1));
        products1.Add(new Product("Mouse", "MSE456", 25.50f, 2));
        products1.Add(new Product("Keyboard", "KBD789", 45.00f, 1));

        List<Product> products2 = new List<Product>();
        products2.Add(new Product("Smartphone", "SMP321", 799.99f, 1));
        products2.Add(new Product("Headphones", "HDP654", 199.99f, 1));
        products2.Add(new Product("Charger", "CHR987", 29.99f, 1));


        Order order1 = new Order(customer1, products1);
        Order order2 = new Order(customer2, products2);

        orders.Add(order1);
        orders.Add(order2);

        foreach(Order order in orders)
        {
            Console.WriteLine($"Total Price: ${order.GetTotalPrice()}");
            Console.WriteLine("Order 1 Packaging Label:");
            order.GetPackagingLabel();
            Console.WriteLine("Order 1 Shipping Label:");
            order.GetShippingLabel();
            Console.WriteLine("---------------------------");
        }
    }
}