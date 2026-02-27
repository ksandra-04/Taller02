namespace WorkshopHeritage.Backend;

public abstract class GeometricFigure
{
    // Constructor
    protected GeometricFigure(string name)
    {
        Name = name;
    }

    // Properties
    public string Name { get; }

    // Métodos públicos abstractos
    public abstract double GetArea();
    public abstract double GetPerimeter();

    // Método para imprimir bonito
    public override string ToString()
    {
        return $"{Name,-15} => Area: {GetArea(),12:N5}   Perimeter: {GetPerimeter(),12:N5}";
    }
}
