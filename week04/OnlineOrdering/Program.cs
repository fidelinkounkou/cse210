using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer c1 = new Customer("John Doe", a1);
        Order o1 = new Order(c1);
        o1.AddProduct(new Product("Mouse", "M01", 20.00, 2));
        o1.AddProduct(new Product("Cable", "C02", 5.00, 1));

        Address a2 = new Address("45 Ave Paix", "Brazzaville", "Cuvette", "Congo");
        Customer c2 = new Customer("Marie Ndolo", a2);
        Order o2 = new Order(c2);
        o2.AddProduct(new Product("Laptop", "L09", 800.00, 1));

        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine($"Total: ${o1.CalculateTotalCost()}\n");

        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine($"Total: ${o2.CalculateTotalCost()}");
    }
}
