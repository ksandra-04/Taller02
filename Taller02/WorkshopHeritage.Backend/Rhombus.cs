namespace WorkshopHeritage.Backend;

public class Rhombus : Square
{
    // Fields
    private double _d1;
    private double _d2;

    // Constructor
    public Rhombus(string name, double d1, double d2, double a)
        : base(name, a)
    {
        _d1 = d1;
        _d2 = d2;
        ValidateD1();
        ValidateD2();
    }

    // Properties
    public double D1 => _d1;
    public double D2 => _d2;

    // Métodos públicos
    public override double GetArea()
    {
        return _d1 * _d2;
    }

    public override double GetPerimeter()
    {
        return 2 * A;
    }

    // Métodos privados
    private void ValidateD1()
    {
        if (_d1 <= 0)
            throw new ArgumentException("D1 must be greater than zero");
    }

    private void ValidateD2()
    {
        if (_d2 <= 0)
            throw new ArgumentException("D2 must be greater than zero");
    }
}