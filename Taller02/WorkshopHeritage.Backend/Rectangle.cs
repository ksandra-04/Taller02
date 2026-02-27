

namespace WorkshopHeritage.Backend;

public class Rectangle : Square
{
    // Fields
    private double _b;

    // Constructor
    public Rectangle(string name, double a, double b)
        : base(name, a)
    {
        _b = b;
        ValidateB();
    }

    // Properties
    public double B => _b;

    // Métodos públicos
    public override double GetArea()
    {
        return A * _b;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + _b);
    }

    // Métodos privados
    private void ValidateB()
    {
        if (_b <= 0)
            throw new ArgumentException("B must be greater than zero");
    }
}
