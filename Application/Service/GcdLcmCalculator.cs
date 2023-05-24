using Application.Exceptions;

namespace Application.Service;

public static class GcdLcmCalculator
{
    public static int CalculateGcd(int a, int b)
    {
        if (a < 0 || b < 0)
        {
            throw IncorrectValueException.NegativeValue(a, b);
        }
        if (a == 0 && b == 0)
        {
            throw IncorrectValueException.ZerosInGcd();
        }

        while (b > 0)
        {
            int tmp = b;
            b = a % b;
            a = tmp;
        }

        return a;
    }

    public static int CalculateLcm(int a, int b)
    {
        if (a == 0 || b == 0)
        {
            throw IncorrectValueException.ZeroInLcm(a, b);
        }

        return a / CalculateGcd(a, b) * b;
    }
}