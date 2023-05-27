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
}