using Shapes.Shapes.Abstractions;

namespace Shapes.Shapes;

public class Circle : ShapeBase
{
    // Радиус круга
    public double Radius { get; set; }

    public Circle(double radius)
    {
        if (radius < 0) throw new Exception("Круг с таким радиусом не может существовать");
        Radius = radius;
    }

    public override double GetSquare()
    {
        return Math.PI * Radius * Radius;
    }
}