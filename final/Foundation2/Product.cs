class Product
{
    private string _name;
    private string _productID;
    private float _pricePerUnit;
    private int _quantity;

    public Product(string name, string productID, float pricePerUnit, int quantity)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public string GetProductName()
    {
        return _name;
    }
    public string GetProductID()
    {
        return _productID;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public float GetTotal()
    {
        return _pricePerUnit * _quantity;
    }
}