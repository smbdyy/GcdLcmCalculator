using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
    }
}