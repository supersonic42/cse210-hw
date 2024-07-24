public class Product(int id, string name, float price, int quantity)
{
    private int _id = id;
    private string _name = name;
    private float _price = price;
    private int _quantity = quantity;

    public float GetTotalPrice()
    {
        return _price * _quantity;
    }

    public int GetId()
    {
        return _id;
    }

    public string  GetName()
    {
        return _name;
    }
}