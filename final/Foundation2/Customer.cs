public class Customer(string name, Address address)
{
    private string _name = name;
    private Address _address = address;

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public bool IsInUsa()
    {
        return GetAddress().IsUsa();
    }
}