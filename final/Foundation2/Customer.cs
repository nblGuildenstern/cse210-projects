public class Customer
{
    private string _name;
    private Address _address;

    public Customer()
    {

    }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool InUSA()
    {
        return _address.InUSA();
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{_name} - {_address.GetAddress()}");
    }
}