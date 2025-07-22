public class Product
{
    private string _name;
    private string _productID;
    private double _pricePerUnit;
    private int _quantity;

    public Product()
    {

    }
    public Product(string name, string productID, double ppu)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = ppu;
    }
    public Product(Product product, int quantity)
    {
        _name = product._name;
        _productID = product._productID;
        _pricePerUnit = product._pricePerUnit;
        _quantity = quantity;
    }

    public double ProductCost()
    {
        return _pricePerUnit * (double)_quantity;
    }
    public void ListProduct()
    {
        Console.WriteLine($"{_name}({_productID})");
    }
}