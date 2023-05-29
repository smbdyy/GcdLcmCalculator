namespace GcdLcmCalculatorApplication.Models;

public record GcdLcmValues(int Gcd, int Lcm)
{
    public int Gcd { get; } = Gcd;
    public int Lcm { get; } = Lcm;
}