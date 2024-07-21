public class Address(string country, string state, string city, string street)
{
    string _country = country;
    string _state = state;
    string _city = city;
    string _street = street;
    
    public bool IsUsa()
    {
        return _country.ToLower() == "us";
    }

    public string GetDisplayString()
    {
        return $"{_country}, {_state}, {_city}, {_street}";
    }
}