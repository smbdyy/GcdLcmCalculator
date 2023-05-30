namespace GcdLcmCalculatorApplication.Resources.Abstractions;

public static class ResourceLoader
{
    private static string Instrctions { get; } = Resources.Instructions.Replace("\n", Environment.NewLine);
}