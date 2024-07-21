public class Customer(string name, Address address)
{
    string _name = name;
    Address _address = address;

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