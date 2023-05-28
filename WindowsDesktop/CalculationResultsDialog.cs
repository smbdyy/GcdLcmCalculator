using GcdLcmCalculatorApplication.MicrosoftOfficeTools;

namespace WindowsDesktop;

public partial class CalculationResultsDialog : Form
{
    public CalculationResultsDialog()
    {
        InitializeComponent();
    }

    public void SetText(string text)
    {
        _messageBox.Text = text;
        Size = new Size(Size.Width, Size.Height + 100);
         _saveResultsButton.Location = _saveResultsButton.Location with { Y = _messageBox.Size.Height + 70};
    }

    public void SaveToWord(object? sender, EventArgs eventArgs)
    {
        using var saveFileDialog = new SaveFileDialog();
        saveFileDialog.AddExtension = true;
        saveFileDialog.Filter = "(DOCX) (.docx)|*.docx|(DOC) (.doc)|*.doc";

        if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

        try
        {
            Word.WriteTextToDoc(_messageBox.Text, saveFileDialog.FileName);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}");
        }
    }
}