using System.ComponentModel;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    private float _shippingCost;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
        _shippingCost = customer.IsInUSA() ? 5 : 35;
    }

    public float GetTotalPrice()
    {
        float total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalPrice();
        }
        return total + _shippingCost;
    }
    public void GetPackagingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetId()} - {product.GetName()}");
        }
    }

    public void GetShippingLabel()
    {
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetAddress().GetFullAddress());
    }
}