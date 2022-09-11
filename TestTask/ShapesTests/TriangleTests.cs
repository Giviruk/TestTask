using Shapes.Shapes;

namespace ShapesTests;

public class TriangleTests
{
    [Theory]
    [InlineData(1, 1, 1)]
    public void CorrectSquare(double a, double b, double c)
    {
        // Arrange
        var triangle = new Triangle(a, b, c);
        var p = (a + b + c) / 2;
        var expectedSquare = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        // Act
        var square = triangle.GetSquare();

        // Assert
        Assert.Equal(expectedSquare, square);
    }

    [Theory]
    [InlineData(1, 1, 1)]
    public void WrongSquare(double a, double b, double c)
    {
        // Arrange
        var triangle = new Triangle(a, b, c);
        var expectedSquare = 2;

        // Act
        var square = triangle.GetSquare();

        // Assert
        Assert.NotEqual(expectedSquare, square);
    }

    [Theory]
    [InlineData(3, 4, 5)]
    public void IsTriangleRectangular(double a, double b, double c)
    {
        // Arrange
        var triangle = new Triangle(a, b, c);

        // Act
        var isRectangular = triangle.IsRectangular();

        // Assert
        Assert.True(isRectangular);
    }

    [Theory]
    [InlineData(4, 5, 3)]
    public void IsTriangleRectangularAnotherSequence(double a, double b, double c)
    {
        // Arrange
        var triangle = new Triangle(a, b, c);

        // Act
        var isRectangular = triangle.IsRectangular();

        // Assert
        Assert.True(isRectangular);
    }

    [Theory]
    [InlineData(4, 5, 2)]
    public void IsTriangleNotRectangular(double a, double b, double c)
    {
        // Arrange
        var triangle = new Triangle(a, b, c);

        // Act
        var isRectangular = triangle.IsRectangular();

        // Assert
        Assert.False(isRectangular);
    }
}