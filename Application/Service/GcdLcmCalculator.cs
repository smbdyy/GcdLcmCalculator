using System.Text;
using Application.Exceptions;

namespace Application.Service;

public static class GcdLcmCalculator
{
    public static string GetCalculationSteps(int a, int b)
    {
        if (a <= 0 || b <= 0)
        {
            throw IncorrectValueException.NonPositive(a, b);
        }

        int aCopy = a;
        int bCopy = b;

        var builder = new StringBuilder($"Рассчитаем НОД чисел {a} и {b}, используя алгоритм Евклида с делением.\n");

        int stepCounter = 1;
        while (b > 0)
        {
            int temp = b;
            b = a % b;
            builder.Append($"{stepCounter}. b = a % b = {a} % {temp} = {b}; a = {temp}.\n");
            stepCounter++;
            a = temp;
        }

        builder.Append($"НОД: {a}, соответственно НОК равен a * b / НОД(a, b) = {aCopy / a * bCopy}.\n");
        return builder.ToString();
    }
}