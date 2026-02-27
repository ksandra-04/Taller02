

namespace WorkshopHeritage.Backend;

public class Parallelogram : Rectangle
{
    // Fields
    private double _h;

    // Constructor
    public Parallelogram(string name, double a, double b, double h)
        : base(name, a, b)
    {
        _h = h;
        ValidateH();
    }

    // Properties
    public double H => _h;

    // Métodos públicos
    public override double GetArea()
    {
        return B * _h;
    }
    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    

    // Métodos privados
    private void ValidateH()
    {
        if (_h <= 0)
            throw new ArgumentException("H must be greater than zero");
    }

}
