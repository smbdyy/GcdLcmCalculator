namespace Application.Exceptions;

public class SpreadsheetReadingException : ApplicationException
{
    public SpreadsheetReadingException(string? message)
        : base(message) { }

    public SpreadsheetReadingException()
        : this("Ошибка при чтении таблицы") { }
}