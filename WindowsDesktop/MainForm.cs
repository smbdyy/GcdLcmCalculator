using GcdLcmCalculatorApplication.MicrosoftOfficeTools;
using GcdLcmCalculatorApplication.Models;
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
        _resultLabel.Text = string.Empty;
        int a = (int)_numberAInput.Value;
        int b = (int)_numberBInput.Value;

        string resultsText = GcdLcmCalculator.GetCalculationSteps(a, b);
        var resultsDialog = new CalculationResultsDialog();
        resultsDialog.SetText(resultsText);
        resultsDialog.ShowDialog();
    }

    private void CalculateButton_Clicked(object? sender, EventArgs eventArgs)
    {
        int a = (int)_numberAInput.Value;
        int b = (int)_numberBInput.Value;

        GcdLcmValues values = GcdLcmCalculator.CalculateValues(a, b);
        _resultLabel.Text = $"НОД: {values.Gcd}, НОК: {values.Lcm}";
    }

    private void NumericUpDown_KeyPress(object? sender, KeyPressEventArgs eventArgs)
    {
        var sep = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
        if (eventArgs.KeyChar == sep)
        {
            eventArgs.Handled = true;
        }
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