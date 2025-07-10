using System;

class Program
{
    static void Main(string[] args)
    {
        Address address_1 = new Address("14801 Dorstack", "Dallas", "Texas", "USA");
        Customer customer_1 = new Customer("\nDave Funkle", address_1);
        Order order_1 = new Order(customer_1);

        Product product_1_1 = new Product("Magic Broom", "211", 89.99f, 3);
        order_1.AddProduct(product_1_1);
        Product product_1_2 = new Product("Flying car", "321", 49.99f, 2);
        order_1.AddProduct(product_1_2);

        order_1.DisplayShippingLabel();
        order_1.DisplayPackingLabels();
        Console.WriteLine($"\nProduct total: ${order_1.CalculateProductTotal()}");
        Console.WriteLine($"Shipping cost: ${order_1.CalculateShippingPrice()}\n");

        Address address_2 = new Address("18701 Stillwaters", "Pheonix", "Arizona", "Greenland");
        Customer customer_2 = new Customer("\nMarkus Truelove", address_2);
        Order order_2 = new Order(customer_2);

        Product product_2_1 = new Product("Fireworks Cannon", "740", 12.99f, 1);
        order_2.AddProduct(product_2_1);
        Product product_2_2 = new Product("Sky Disruptor", "654", 99.99f, 4);
        order_2.AddProduct(product_2_2);

        order_2.DisplayShippingLabel();
        order_2.DisplayPackingLabels();
        Console.WriteLine($"\nProduct total: ${order_2.CalculateProductTotal()}");
        Console.WriteLine($"Shipping cost: ${order_2.CalculateShippingPrice()}\n");

    }
}