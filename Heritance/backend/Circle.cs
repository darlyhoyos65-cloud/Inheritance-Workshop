
namespace backend;



public class Circle : GeometricFigure
{
    private double _r;
    public double R

    {
        get => _r;
        set => _r = ValidateR(value);
    }

    public Circle(string name, double r) : base(name)
    {
        R = r;
        Name = name;

    }

    public override double GetArea() => Math.PI * R * R;
    public override double GetPerimeter() => 2 * Math.PI * R;

    private double ValidateR(double r)
    {
        if (r <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(r), $"The radius: {r} is invalid.");
        }
        return r;
    }
}