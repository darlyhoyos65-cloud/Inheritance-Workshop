namespace backend;

public class Square : GeometricFigure
{

    private double _a;

    public Square(string name, double a) : base(name)
    {
        A = a;
        Name = name;
    }
    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }



    public override double GetArea() => A * A;
    public override double GetPerimeter() => 4 * A;

    private double ValidateA(double a)
    {
        if (a <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(a), $"The side: {a} is invalid.");
        }
        return a;
    }
}