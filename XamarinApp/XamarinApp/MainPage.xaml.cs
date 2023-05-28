using System;
using GcdLcmCalculatorApplication.Service;
using Xamarin.Forms;

namespace XamarinApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void CalculateButton_Clicked(object sender, EventArgs e)
        {
            ResultLabel.Text = "";
            if (int.TryParse(NumberAEntry.Text, out var numberA) && int.TryParse(NumberBEntry.Text, out var numberB)
                                                                 && numberA > 0 && numberB > 0)
            {
                await Navigation.PushAsync(new ResultsPage(GcdLcmCalculator.GetCalculationSteps(numberA, numberB)));
            }
            else
            {
                ResultLabel.Text = "Ошибка: введите два натуральных числа.";
            }
        }
    }
}