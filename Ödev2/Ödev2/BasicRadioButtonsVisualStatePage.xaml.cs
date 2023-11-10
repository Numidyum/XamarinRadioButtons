using Xamarin.Forms;

namespace Ödev2
{
    public partial class BasicRadioButtonsVisualStatePage : ContentPage
    {
        public BasicRadioButtonsVisualStatePage()
        {
            InitializeComponent();
        }

        void OnRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            resultLabel.Text = $"Seçtiğin: {button.Content}";
        }
    }
}
