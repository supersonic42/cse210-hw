public class Order()
{
    private List<Product> _products = [];
    private Customer _customer;

    public float GetTotalCost()
    {
        float cost = 0;

        foreach(Product product in _products)
        {
            cost += product.GetTotalPrice();
        }

        // Shipping cost
        cost += _customer.IsInUsa() ? 5 : 35;

        return cost;
    }

    public string GetPackingLabel()
    {
        string label = "";

        foreach(Product product in _products)
        {
            label += $"\n - {product.GetName()} (id {product.GetId()})";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return $"\n - {_customer.GetName()} | {_customer.GetAddress().GetDisplayString()}";
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}