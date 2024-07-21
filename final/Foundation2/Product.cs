public class Product(int id, string name, float price, int quantity)
{
    private int _id = id;
    string _name = name;
    float _price = price;
    int _quantity = quantity;

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