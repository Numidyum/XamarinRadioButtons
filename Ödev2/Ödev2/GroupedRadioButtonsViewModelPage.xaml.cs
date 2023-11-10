using Xamarin.Forms;

namespace Ödev2
{
    public partial class GroupedRadioButtonsViewModelPage : ContentPage
    {
        public GroupedRadioButtonsViewModelPage()
        {
            InitializeComponent();
            BindingContext = new AnimalViewModel
            {
                GroupName = "animals",
                Selection = "Monkey"
            };
        }
    }
}
