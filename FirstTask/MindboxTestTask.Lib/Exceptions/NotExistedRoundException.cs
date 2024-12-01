namespace MindboxTestTask.Lib.Exceptions;

public class NotExistedRoundException(double radius) : Exception($"Круг с радиусом={radius} не может существовать.")
{ }