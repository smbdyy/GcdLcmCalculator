using Application.Service;

namespace WindowsDesktop;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void ShowCalculationResults(object? sender, EventArgs eventArgs)
    {
        int a = (int)_numberAInput.Value;
        int b = (int)_numberBInput.Value;

        string resultsText = GcdLcmCalculator.GetCalculationSteps(a, b);
        var resultsDialog = new CalculationResultsDialog();
        resultsDialog.SetText(resultsText);
        resultsDialog.ShowDialog();
    }
}