using System;
using GcdLcmCalculatorApplication.MicrosoftOfficeTools;
using GcdLcmCalculatorApplication.Models;
using GcdLcmCalculatorApplication.Resources.Abstractions;
using GcdLcmCalculatorApplication.Service;
using Xamarin.Essentials;
using Xamarin.Forms;
using XamarinApp.Constants;

namespace XamarinApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ShowSolutionButton_Clicked(object? sender, EventArgs eventArgs)
        {
            ResultLabel.Text = "";
            if (TryParseNumbers(out var numberA, out var numberB))
            {
                await Navigation.PushAsync(new ResultsPage(GcdLcmCalculator.GetCalculationSteps(numberA, numberB)));
            }
            else
            {
                ResultLabel.Text = "Ошибка: введите два натуральных числа.";
            }
        }

        private void CalculateButton_Clicked(object? sender, EventArgs eventArgs)
        {
            ResultLabel.Text = "";
            if (TryParseNumbers(out var numberA, out var numberB))
            {
                GcdLcmValues values = GcdLcmCalculator.CalculateValues(numberA, numberB);
                ResultLabel.Text = $"НОД: {values.Gcd}, НОК: {values.Lcm}";
            }
            else
            {
                ResultLabel.Text = "Ошибка: введите два натуральных числа.";
            }
        }

        private bool TryParseNumbers(out int numberA, out int numberB)
        {
            if (int.TryParse(NumberAEntry.Text, out var number1) && int.TryParse(NumberBEntry.Text, out var number2)
                                                                 && number1 > 0 && number2 > 0)
            {
                numberA = number1;
                numberB = number2;
                return true;
            }

            numberA = 1;
            numberB = 1;
            return false;
        }

        private async void LoadDataFromTable_Clicked(object? sender, EventArgs eventArgs)
        {
            try
            {
                var options = new PickOptions
                {
                    FileTypes = FilePickerFileTypes.SpreadsheetType
                };

                FileResult? fileResult = await FilePicker.PickAsync(options);

                if (fileResult == null) return;
                string filePath = fileResult.FullPath;
                Tuple<int, int> numbers = Spreadsheets.ReadTwoNumbersFromTable(filePath);

                NumberAEntry.Text = $"{numbers.Item1}";
                NumberBEntry.Text = $"{numbers.Item2}";
            }
            catch (Exception ex)
            {
                ResultLabel.Text = "Произошла ошибка при открытии файла.";
            }
        }

        private async void ShowInstructionsButton_Clicked(object? sender, EventArgs eventArgs)
        {
            await Navigation.PushAsync(new ResultsPage(ResourceLoader.Instructions));
        }
    }
}