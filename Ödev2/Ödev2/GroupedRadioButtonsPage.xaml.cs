using Xamarin.Forms;

namespace Ödev2
{
    public partial class GroupedRadioButtonsPage : ContentPage
    {
        public GroupedRadioButtonsPage()
        {
            InitializeComponent();
        }

        void OnColorsRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            colorLabel.Text = $"Seçimin: {button.Content}";
        }

        void OnFruitsRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            fruitLabel.Text = $"Seçimin: {button.Content}";
        }
    }
}
