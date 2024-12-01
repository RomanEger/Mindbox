using MindboxTestTask.Lib.Exceptions;
using MindboxTestTask.Lib.Factories;
using MindboxTestTask.Lib.Services;

namespace MindboxTestTask.Test;

public class FigureTest
{
    [Theory]
    [InlineData(1.0, 2.5, 3.0)]
    public void Test_TriangleArea_CorrectSides(params double[] sides)
    {
        Assert.IsType<double>(FigureFactory.CreateFigure(sides).GetArea());
    }
    
    [Theory]
    [InlineData(1.0, 2.0, 3.0)]
    [InlineData(0.0, 0.0, 0.0)]
    [InlineData(-1.0, 0.0, 0.0)]
    [InlineData(1.0, 1.0, 0.0)]
    public void Test_TriangleArea_IncorrectSides(params double[] sides)
    {
        Assert.Throws<NotExistedTriangleException>(() => FigureFactory.CreateFigure(sides).GetArea());
    }

    [Theory]
    [InlineData(3.0, 4.0, 5.0)]
    [InlineData(4.6, 10.0, 11.0)]
    public void Test_Triangle_Right(double sideA, double sideB, double sideC)
    {
        Assert.True(new Triangle(sideA, sideB, sideC).IsRightTriangle());
    }
    
    [Theory]
    [InlineData(1.0, 2.0, 2.0)]
    public void Test_Triangle_NotRight(double sideA, double sideB, double sideC)
    {
        Assert.False(new Triangle(sideA, sideB, sideC).IsRightTriangle());
    }

    [Theory]
    [InlineData(1)]
    public void Test_Round_CorrectRadius(double radius)
    {
        Assert.IsType<double>(FigureFactory.CreateFigure(radius).GetArea());
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void Test_Round_IncorrectRadius(double radius)
    {
        Assert.Throws<NotExistedRoundException>(() => FigureFactory.CreateFigure(radius).GetArea());
    }

    [Theory]
    [InlineData(2.0, 1.0)]
    public void Test_NotImplementedFigure(params double[] sides)
    {
        Assert.Throws<NotImplementedException>(() => FigureFactory.CreateFigure(sides));
    }
}