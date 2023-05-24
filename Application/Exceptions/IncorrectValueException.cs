namespace Application.Exceptions;

public class IncorrectValueException : ApplicationException
{
    public IncorrectValueException(string? message)
        : base(message) { }

    public static IncorrectValueException NegativeValue(int a, int b)
        => new($"Невозможно рассчитать значение: ввод содержит отрицательное число ({a}, {b})");

    public static IncorrectValueException ZerosInGcd()
        => new("Невозможно рассчитать НОД: оба числа равны нулю");

    public static IncorrectValueException ZeroInLcm(int a, int b)
        => new($"Невозможно рассчитать значение: ввод содержит ноль ({a}, {b})");
}