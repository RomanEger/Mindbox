using MindboxTestTask.Lib.Services;

namespace MindboxTestTask.Lib.Factories;

public static class FigureFactory
{
    public static ICalculateFigureArea CreateFigure(params double[] sides)
    {
        return sides.Length switch
        {
            1 => new Round(sides[0]),
            3 => new Triangle(sides[0], sides[1], sides[2]),
            _ => throw new NotImplementedException()
        };
    }
}