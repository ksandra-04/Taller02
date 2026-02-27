namespace WorkshopHeritage.Backend;

public class Trapeze : Triangle
{
    // Fields
    private double _d;

    // Constructor
    public Trapeze(string name, double a, double b, double c, double d, double h)
        : base(name, a, b, c, h)
    {
        _d = d;
        ValidateD();
    }

    // Properties
    public double D => _d;

    // Métodos públicos
    public override double GetArea()
    {
        return ((B + _d) * H) / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + C + _d;
    }

    // Métodos privados
    private void ValidateD()
    {
        if (_d <= 0)
            throw new ArgumentException("D must be greater than zero");
    }
}
