using Shapes.Shapes.Abstractions;

namespace Shapes.Shapes;

public class Circle : ShapeBase
{
    // Радиус круга
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetSquare()
    {
        return Math.PI * Radius * Radius;
    }
}