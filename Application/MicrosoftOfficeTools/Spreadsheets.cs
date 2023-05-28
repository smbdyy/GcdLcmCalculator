using Application.Exceptions;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Application.MicrosoftOfficeTools;

public static class Spreadsheets
{
    public static Tuple<int, int> ReadTwoNumbersFromTable(string filePath)
    {
        using var document = SpreadsheetDocument.Open(filePath, false);
        WorkbookPart? workbookPart = document.WorkbookPart;

        if (workbookPart == null)
        {
            throw new SpreadsheetReadingException();
        }

        WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
        Worksheet worksheet = worksheetPart.Worksheet;
        SheetData? sheetData = worksheet.GetFirstChild<SheetData>();

        if (sheetData == null)
        {
            throw new SpreadsheetReadingException();
        }

        int a = GetCellValue(sheetData, "A1");
        int b = GetCellValue(sheetData, "A2");

        return new Tuple<int, int>(a, b);
    }

    public static int GetCellValue(SheetData sheetData, string cellReference)
    {
        Cell cell = GetCell(sheetData, cellReference);
        if (cell.DataType != null && cell.DataType.Value == CellValues.Number && cell.CellValue != null)
        {
            return int.Parse(cell.CellValue.Text);
        }
        return 0;
    }

    public static Cell GetCell(SheetData sheetData, string cellReference)
    {
        foreach (Row row in sheetData.Elements<Row>())
        {
            foreach (Cell cell in row.Elements<Cell>())
            {
                if (cell.CellReference?.Value == cellReference)
                {
                    return cell;
                }
            }
        }

        throw new SpreadsheetReadingException();
    }
}