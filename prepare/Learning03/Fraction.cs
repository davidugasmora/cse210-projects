class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string numStr = $"{_top}/{_bottom}";
        return numStr;
    }

    public double GetDecimalValue()
    {
        double numDbl = (double)_top / (double)_bottom;
        return numDbl;
    }

}


