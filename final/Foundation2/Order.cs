class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine($"{_customer.GetCostumerName()}, Address: {_customer.GetCostumerAddress()}\n");
    }

    public void DisplayPackingLabels()
    {
        Console.WriteLine("Packing labels:");
        foreach (Product product in _products)
        {
            for (int iProduct = 0; iProduct < product.GetQuantity(); iProduct++)
                Console.WriteLine($"{product.GetProductName()}, {product.GetProductID()}");
        }
    }

    public float CalculateProductTotal()
    {
        float total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotal();
        }

        return total;
    }

    public int CalculateShippingPrice()
    {
        return _customer.IsCustomerInUSA() ? 5 : 35;
    }
}