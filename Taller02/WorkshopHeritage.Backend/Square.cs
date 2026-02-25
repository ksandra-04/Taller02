namespace WorkshopHeritage.Backend;

public class Square : GeometricFigure
{
    // Fields
    private double _a;

    // Constructor
    public Square(string name, double a) : base(name)
    {
        _a = a;
        ValidateA();
    }

    // Properties
    public double A => _a;

    // Métodos públicos
    public override double GetArea() => _a * _a;

    public override double GetPerimeter() => 4 * _a;

    // Métodos privados
    private void ValidateA()
    {
        if (_a <= 0)
            throw new ArgumentException("A must be greater than zero");
    }
}
