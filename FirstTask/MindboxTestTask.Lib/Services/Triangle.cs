using MindboxTestTask.Lib.Exceptions;

namespace MindboxTestTask.Lib.Services;

public class Triangle : ICalculateFigureArea
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0
            || sideB <= 0
            || sideC <= 0
            || sideA + sideB <= sideC
            || sideA + sideC <= sideB
            || sideB + sideC <= sideA)
        {
            throw new NotExistedTriangleException(SideA, SideB, SideC);
        }
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double GetPerimeter()
    {
        return SideA + SideB + SideC;
    }

    /// <inheritdoc />
    public double GetArea()
    {
        var halfPerimeter = GetPerimeter() / 2;
        
        return Math.Sqrt(halfPerimeter *
                         (halfPerimeter - SideA) *
                         (halfPerimeter - SideB) *
                         (halfPerimeter - SideC));
    }

    public bool IsRightTriangle()
    {
        return
            Math.Round(Math.Pow(SideA, 2)) == Math.Round(Math.Pow(SideB, 2)) + Math.Round(Math.Pow(SideC, 2))
            || Math.Round(Math.Pow(SideB, 2)) == Math.Round(Math.Pow(SideA, 2)) + Math.Round(Math.Pow(SideC, 2))
            || Math.Round(Math.Pow(SideC, 2)) == Math.Round(Math.Pow(SideB, 2)) + Math.Round(Math.Pow(SideA, 2));
    }
}