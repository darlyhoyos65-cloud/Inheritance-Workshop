namespace backend;



public class Kite : Rhombus
{
    private double _b;

    public Kite(string name, double d1, double d2, double a, double b) : base(name, d1, d2, a)
    {
        B = b;
    }

    public double B

    {
        get => _b;
        set => _b = ValidateB(value);
    }



    public override double GetArea() => base.GetArea();
    public override double GetPerimeter() => 2 * (A + B);

    private double ValidateB(double b)
    {
        if (b <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(b), $"The length: {b} is invalid.");
        }
        return b;
    }
}