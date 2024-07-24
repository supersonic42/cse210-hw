public class OutdoorEvent(
    string title, 
    string description, 
    DateTime dateTime, 
    Address address, 
    string weatherForecast
) : Event (title, description, dateTime, address)
{
    private string _weatherForecast = weatherForecast;

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()} | {GetLiteralType()} | Weather forecast: {_weatherForecast}";
    }

    protected override string GetLiteralType()
    {
        return "Outdoor";
    }
}