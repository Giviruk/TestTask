using Shapes.Shapes.Abstractions;

namespace Shapes.Shapes;

public class Triangle : ShapeBase
{
    // Длина стороны A
    public double A { get; protected set; }

    // Длина стороны B
    public double B { get; protected set; }

    // Длина стороны C
    public double C { get; protected set; }

    // Полупериметр
    public double P { get; set; }

    public Triangle(double a, double b, double c)
    {
        if (!(a + b > c && a + c > b && c + b > a && a > 0 && b > 0 && c > 0))
            throw new Exception("Треугольник с такими вершинами не может существовать");
        A = a;
        B = b;
        C = c;
        P = (A + B + C) / 2;
    }

    public override double GetSquare()
    {
        return Math.Sqrt(P * (P - A) * (P - B) * (P - C));
    }

    public bool IsRectangular()
    {
        if (A > B && A > C)
        {
            return Math.Abs(A * A - (B * B + C * C)) < 0.1f;
        }

        if (B > A && B > C)
        {
            return Math.Abs(B * B - (A * A + C * C)) < 0.1f;
        }

        if (C > A && C > B)
        {
            return Math.Abs(C * C - (A * A + B * B)) < 0.1f;
        }

        return false;
    }
}