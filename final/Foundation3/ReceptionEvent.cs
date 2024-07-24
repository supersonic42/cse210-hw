public class ReceptionEvent(
    string title, 
    string description, 
    DateTime dateTime, 
    Address address, 
    string email
) : Event (title, description, dateTime, address)
{
    private string _email = email;

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()} | {GetLiteralType()} | Email: {_email}";
    }

    protected override string GetLiteralType()
    {
        return "Reception";
    }
}