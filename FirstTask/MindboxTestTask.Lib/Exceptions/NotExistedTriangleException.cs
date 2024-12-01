namespace MindboxTestTask.Lib.Exceptions;

public class NotExistedTriangleException(double sideA, double sideB, double sideC) : Exception($"Треугольник со сторонами A={sideA} B={sideB} C={sideC} не может существовать.")
{ }