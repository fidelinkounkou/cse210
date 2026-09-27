using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product) => _products.Add(product);

    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (Product p in _products) total += p.GetTotalCost();
        total += _customer.LivesInUSA() ? 5.00 : 35.00;
        return total;
    }

    public string GetPackingLabel()
    {
        string text = "Packing List:\n";
        foreach (Product p in _products) text += $"- {p.GetName()} (ID: {p.GetProductId()})\n";
        return text;
    }

    public string GetShippingLabel()
    {
        return $"Ship To:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}\n";
    }
}
