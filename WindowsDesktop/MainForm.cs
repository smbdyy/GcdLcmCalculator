using GcdLcmCalculatorApplication.MicrosoftOfficeTools;
using GcdLcmCalculatorApplication.Service;

namespace WindowsDesktop;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void ShowSolutionButton_Clicked(object? sender, EventArgs eventArgs)
    {
        int a = (int)_numberAInput.Value;
        int b = (int)_numberBInput.Value;

        string resultsText = GcdLcmCalculator.GetCalculationSteps(a, b);
        var resultsDialog = new CalculationResultsDialog();
        resultsDialog.SetText(resultsText);
        resultsDialog.ShowDialog();
    }

    private void LoadDataFromTableButton_Clicked(object? sender, EventArgs eventArgs)
    {
        using var openFileDialog = new OpenFileDialog();
        openFileDialog.AddExtension = true;
        openFileDialog.CheckFileExists = true;
        openFileDialog.CheckPathExists = true;
        openFileDialog.Filter = "XLSX (.xlsx)|*.xlsx";

        if (openFileDialog.ShowDialog() != DialogResult.OK) return;

        try
        {
            Tuple<int, int> numbers = Spreadsheets.ReadTwoNumbersFromTable(openFileDialog.FileName);
            if (numbers.Item1 <= 0 || numbers.Item2 <= 0)
            {
                MessageBox.Show($"Ввод содержит неположительное число: {numbers.Item1}, {numbers.Item2}");
            }

            _numberAInput.Value = numbers.Item1;
            _numberBInput.Value = numbers.Item2;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при открытии файла: {ex.Message}");
        }
    }
}