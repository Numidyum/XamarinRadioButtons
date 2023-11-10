using Xamarin.Forms;

namespace Ödev2
{
    public partial class BasicRadioButtonsPage : ContentPage
    {
        public BasicRadioButtonsPage()
        {
            InitializeComponent();
        }

        void OnAnimalRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            animalLabel.Text = $"Seçimin: {button.Content}";
        }

        void OnAnimalImageRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            animalImageLabel.Text = $"Seçimin: {button.Value}";
        }
    }
}
