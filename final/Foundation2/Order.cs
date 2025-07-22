public class Order
{

    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order()
    {

    }
    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product newProduct)
    {
        _products.Add(newProduct);
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.ProductCost();
        }
        if (_customer.InUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    public void PackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.Write("\t");
            product.ListProduct();
        }
    }

    public void ShippingLabel()
    {
        _customer.PrintInfo();
    }
}