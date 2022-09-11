using Shapes.Shapes;
using Shapes.Shapes.Abstractions;

namespace UsingExample;

public static class Program
{
    public static void Main()
    {
        var triangle = new Triangle(1, 1, 1);
        var triangleShape = triangle as ShapeBase;

        // В compile time не имеет значения какой именно экземпляр класса используется для подсчета площади,
        // можем работать с абстракцией
        var triangleSquare = triangleShape.GetSquare();

        var circle = new Circle(1);
        var circleShape = circle as ShapeBase;

        // В compile time не имеет значения какой именно экземпляр класса используется для подсчета площади,
        // можем работать с абстракцией
        var circleSquare = circleShape.GetSquare();
    }
}