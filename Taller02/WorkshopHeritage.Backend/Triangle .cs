namespace WorkshopHeritage.Backend;

public class Triangle : Rectangle
{
    // Fields
    private double _c;
    private double _h;

    // Constructor
    public Triangle(string name, double a, double b, double c, double h)
        : base(name, a, b)
    {
        _c = c;
        _h = h;
        ValidateC();
        ValidateH();
    }

    // Properties
    public double C => _c;
    public double H => _h;

    // Métodos públicos
    public override double GetArea()
    {
        return (B * _h) / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + _c;
    }

    // Métodos privados
    private void ValidateC()
    {
        if (_c <= 0)
            throw new ArgumentException("C must be greater than zero");
    }

    private void ValidateH()
    {
        if (_h <= 0)
            throw new ArgumentException("H must be greater than zero");
    }
}
