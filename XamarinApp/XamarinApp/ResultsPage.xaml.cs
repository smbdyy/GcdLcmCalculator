using System;
using GcdLcmCalculatorApplication.MicrosoftOfficeTools;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Constants;

namespace XamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultsPage : ContentPage
    {
        public ResultsPage(string resultText)
        {
            InitializeComponent();
            ResultTextLabel.Text = resultText;
        }

        public async void SaveResultsButton_Clicked(object? sender, EventArgs eventArgs)
        {
            var options = new PickOptions
            {
                FileTypes = FilePickerFileTypes.WordDocumentType
            };

            FileResult? fileResult = await FilePicker.PickAsync(options);
            if (fileResult == null) return;

            string filePath = fileResult.FullPath;
            Word.WriteTextToDoc(ResultTextLabel.Text, filePath);
        }
    }
}