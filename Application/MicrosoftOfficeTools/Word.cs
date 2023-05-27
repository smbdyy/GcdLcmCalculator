using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace Application.MicrosoftOfficeTools;

public static class Word
{
    public static void WriteTextToDoc(string text, string filePath)
    {
        using var wordDoc = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document);
        MainDocumentPart mainPart = wordDoc.AddMainDocumentPart();
        mainPart.Document = new Document();

        string[] lines = text.Split('\n');

        var body = new Body();

        foreach (string line in lines)
        {
            var paragraph = new Paragraph();
            var run = new Run(new Text(line));

            paragraph.Append(run);
            paragraph.Append(new Break());

            body.Append(paragraph);
        }

        mainPart.Document.Body = body;
    }
}