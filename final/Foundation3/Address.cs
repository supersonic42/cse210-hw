public class Address(string country, string state, string city, string street)
{
    private string _country = country;
    private string _state = state;
    private string _city = city;
    private string _street = street;

    public string GetDisplayString()
    {
        return $"{_country}, {_state}, {_city}, {_street}";
    }
}