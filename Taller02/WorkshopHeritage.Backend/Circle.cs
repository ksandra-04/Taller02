namespace WorkshopHeritage.Backend;

public class Circle : GeometricFigure
{
    // 1Fields
    private double _r;

    // Constructor
    public Circle(string name, double r) : base(name)
    {
        _r = r;
        ValidateR();
    }

    // Properties
    public double R
    {
        get => _r;
    }

    //  Métodos públicos
    public override double GetArea()
    {
        return Math.PI * _r * _r;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * _r;
    }

    // Métodos privados
    private void ValidateR()
    {
        if (_r <= 0)
            throw new ArgumentException("Radius must be greater than zero");

    }
}
