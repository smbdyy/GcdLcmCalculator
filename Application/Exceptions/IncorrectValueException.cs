namespace Application.Exceptions;

public class IncorrectValueException : ApplicationException
{
    public IncorrectValueException(string? message)
        : base(message) { }

    public static IncorrectValueException NonPositive(int a, int b)
        => new($"Невозможно рассчитать значения: ввод содержит неположительное число ({a}, {b})");
}