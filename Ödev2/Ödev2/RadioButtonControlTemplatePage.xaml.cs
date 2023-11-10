using Xamarin.Forms;

namespace Ödev2
{
    public partial class RadioButtonControlTemplatePage : ContentPage
    {
        public RadioButtonControlTemplatePage()
        {
            InitializeComponent();
        }


        void OnAnimalRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            animalLabel.Text = $"Seçimin: {button.Value}";
        }
    }
}
