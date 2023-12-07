using CommunityToolkit.Maui.Views;

namespace MauiApp32
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            //await this.Navigation.ShowPopupAsync(page);
            this.ShowPopup(new NewPopup());
        }
    }

}
