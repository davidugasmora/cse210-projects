class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius)
    : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double circleArea = Math.PI * Math.Pow(_radius, 2);
        return circleArea;
    }
}