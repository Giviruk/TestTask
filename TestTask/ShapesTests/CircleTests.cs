using Shapes.Shapes;

namespace ShapesTests;

public class CircleTests
{
    [Theory]
    [InlineData(1)]
    public void CorrectSquare(double radius)
    {
        // Arrange
        var circle = new Circle(radius);
        var expectedSquare = Math.PI * radius * radius;

        // Act
        var square = circle.GetSquare();

        // Assert
        Assert.Equal(expectedSquare, square);
    }

    [Theory]
    [InlineData(1)]
    public void WrongSquare(double radius)
    {
        // Arrange
        var circle = new Circle(radius);
        var expectedSquare = 2;

        // Act
        var square = circle.GetSquare();

        // Assert
        Assert.NotEqual(expectedSquare, square);
    }
}