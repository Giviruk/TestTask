using Shapes.Shapes;
using Shapes.Shapes.Abstractions;

namespace TestTask;

public class Program
{
    public void Main()
    {
        var triangle = new Triangle(1, 1, 1);
        var triangleShape = triangle as ShapeBase;
        var triangleSquare = triangleShape.GetSquare();

        var circle = new Circle(1);
        var circleShape = circle as ShapeBase;
        var circleSquare = circleShape.GetSquare();
    }
}