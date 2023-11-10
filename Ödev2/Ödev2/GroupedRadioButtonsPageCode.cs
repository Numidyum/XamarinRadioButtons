using Xamarin.Forms;

namespace Ödev2
{
    public class GroupedRadioButtonsPageCode : ContentPage
    {
        Label colorLabel;
        Label fruitLabel;

        public GroupedRadioButtonsPageCode()
        {
            fruitLabel = new Label { Text = "Seçimin:" };
            colorLabel = new Label { Text = "Seçimin:" };

            RadioButton redRadioButton = new RadioButton { Content = "Kırmızı", TextColor = Color.Red, GroupName="colors" };
            redRadioButton.CheckedChanged += OnColorsRadioButtonCheckedChanged;
            RadioButton greenRadioButton = new RadioButton { Content = "Yeşil", TextColor = Color.Green, GroupName = "colors" };
            greenRadioButton.CheckedChanged += OnColorsRadioButtonCheckedChanged;
            RadioButton blueRadioButton = new RadioButton { Content = "Mavi", TextColor = Color.Blue, GroupName = "colors" };
            blueRadioButton.CheckedChanged += OnColorsRadioButtonCheckedChanged;
            RadioButton otherColorRadioButton = new RadioButton { Content = "Diğer", GroupName = "colors" };
            otherColorRadioButton.CheckedChanged += OnColorsRadioButtonCheckedChanged;

            RadioButton appleRadioButton = new RadioButton { Content = "Elma" };
            appleRadioButton.CheckedChanged += OnFruitsRadioButtonCheckedChanged;
            RadioButton bananaRadioButton = new RadioButton { Content = "Muz" };
            bananaRadioButton.CheckedChanged += OnFruitsRadioButtonCheckedChanged;
            RadioButton pineappleRadioButton = new RadioButton { Content = "Ananas" };
            pineappleRadioButton.CheckedChanged += OnFruitsRadioButtonCheckedChanged;
            RadioButton otherFruitRadioButton = new RadioButton { Content = "Diğer" };
            otherFruitRadioButton.CheckedChanged += OnFruitsRadioButtonCheckedChanged;

            StackLayout fruitStackLayout = new StackLayout
            {
                Children = { appleRadioButton, bananaRadioButton, pineappleRadioButton, otherFruitRadioButton }
            };

            // All of the RadioButtons in this StackLayout will automatically be given the GroupName 'fruits'.
            RadioButtonGroup.SetGroupName(fruitStackLayout, "fruits");

            Title = "Grouped RadioButtons demo (code)";
            Content = new StackLayout
            {
                Margin = new Thickness(10),
                Children =
                {
                    new Label { Text = "En sevdiğin renk nedir?" },
                    redRadioButton,
                    greenRadioButton,
                    blueRadioButton,
                    otherColorRadioButton,
                    colorLabel,
                    new Label { Text = "En sevdiğin meyve nedir?" },
                    fruitStackLayout,
                    fruitLabel
                }
            };
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

