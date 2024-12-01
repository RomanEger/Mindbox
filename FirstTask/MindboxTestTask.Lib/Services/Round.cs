using MindboxTestTask.Lib.Exceptions;

namespace MindboxTestTask.Lib.Services;

public class Round : ICalculateFigureArea
{
    public double Radius { get; }

    public Round(double radius)
    {
        if (radius <= 0)
            throw new NotExistedRoundException(radius);
        Radius = radius;
    }
    
    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}