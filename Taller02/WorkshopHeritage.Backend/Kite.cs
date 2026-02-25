namespace WorkshopHeritage.Backend;

public class Kite : Rhombus
{
    // Fields
    private double _b;

    // Constructor
    public Kite(string name, double a, double d1, double d2, double b)
        : base(name, d1, d2, a)
    {
        _b = b;
        ValidateB();
    }

    // Properties
    public double B => _b;

    // Métodos públicos
    public override double GetArea()
    {
        return (D1 * D2) / 2;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + _b); // 
    }

    // Métodos privados
    private void ValidateB()
    {
        if (_b <= 0)
            throw new ArgumentException("B must be greater than zero");
    }
}
