class PoliceMan : Person
{
    private string _weapons;
    private int _hoursWorked;
    private double _hourlyWage;

    public PoliceMan(string firstName, string lastName,
                     int age, string weapons, int hoursWorked, double hourlyWage)
    : base(firstName, lastName, age)
    {
        _weapons = weapons;
        _hoursWorked = hoursWorked;
        _hourlyWage = hourlyWage;
    }

    // public string GetPoliceManInforamtion()
    // {
    //     return $"Weapons: {_weapons} :: {GetPersonInformation()}";
    // }

    public override string GetPersonInformation()
    {
        return $"Weapons: {_weapons} :: {base.GetPersonInformation()}";
    }

    public override double GetSalary()
    {
        double pay = _hoursWorked * _hourlyWage;
        if (_hoursWorked > 40)
        {
            return pay += (_hoursWorked - 40) * _hourlyWage * 2;
        }

        return pay;
    }
}