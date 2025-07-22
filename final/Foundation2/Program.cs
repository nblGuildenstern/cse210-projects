using System;

class Program
{
    static void Main(string[] args)
    {
        Product apples = new Product("Apples", "1253", .79);
        Product bananas = new Product("Bananas", "3452", .35);
        Product oranges = new Product("Oranges", "4346", .62);
        Product pears = new Product("Pears", "6343", .99);
        Product watermelons = new Product("Watermelons", "2346", 4.35);

        Customer customer1 = new Customer("Kryton", new Address("35330 Billie Ann Rd",
                                            "Wildomar", "California", "United States"));
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product(apples, 5));
        order1.AddProduct(new Product(bananas, 4));
        order1.AddProduct(new Product(watermelons, 2));

        Customer customer2 = new Customer("Spencer", new Address("50 E North Temple Street",
                                            "Salt Lake City", "Utah", "United States"));
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product(oranges, 10));
        order2.AddProduct(new Product(pears, 3));
        order2.AddProduct(new Product(bananas, 6));

        order1.ShippingLabel();
        order1.PackingLabel();
        double price1 = order1.CalculateTotal();
        Console.Write("\t");
        Console.WriteLine($"${price1:0.00}\n");

        order2.ShippingLabel();
        order2.PackingLabel();
        double price2 = order2.CalculateTotal();
        Console.Write("\t");
        Console.WriteLine($"${price2:0.00}");
    }
}