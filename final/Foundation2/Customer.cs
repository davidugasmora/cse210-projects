class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsCustomerInUSA() => _address.IsInUSA();

    public string GetCostumerAddress() => _address.GetAddress();

    public string GetCostumerName()
    {
        return _name;
    }
}