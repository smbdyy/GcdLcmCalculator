using System;
using Xamarin.Forms;

namespace XamarinApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CalculateButton_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(NumberAEntry.Text, out var number1) && int.TryParse(NumberBEntry.Text, out var number2))
            {
                ResultLabel.Text = $"Введенные числа: {number1}, {number2}";
            }
            else
            {
                ResultLabel.Text = "Ошибка: введите два целых числа.";
            }
        }
    }
}