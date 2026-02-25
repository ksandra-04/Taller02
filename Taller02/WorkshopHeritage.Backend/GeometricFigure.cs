namespace WorkshopHeritage.Backend;

public abstract class GeometricFigure
{
    // Fields
    private string _name;

    // Constructor
    protected GeometricFigure(string name)
    {
        _name = name;
    }

    // Properties
    public string Name => _name;

    // Métodos públicos abstractos
    public abstract double GetArea();
    public abstract double GetPerimeter();

    // Método para imprimir bonito
    public override string ToString()
    {
        return $"{Name,-15} => Area: {GetArea(),10:N5}   Perimeter: {GetPerimeter(),10:N5}";
    }
}