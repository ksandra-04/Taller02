namespace WorkshopHeritage.Backend;

public class Square : GeometricFigure
{
    // Fields
    private double _a;

    // Constructor
    public Square(string name, double a) : base(name)
    {
        ValidateA(a);
        _a = a;
    }

    // Properties
    public double A => _a;

    // Métodos públicos
    public override double GetArea() => _a * _a;

    public override double GetPerimeter() => 4 * _a;

    // Métodos privados
    private void ValidateA(double value)
    {
        if (value <= 0)
            throw new ArgumentException("A must be greater than zero");
    }
}
