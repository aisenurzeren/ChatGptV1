namespace ChatGptV1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {

        }

        private void Click_SagMenu(object sender, TappedEventArgs e)
        {
            frameSagMenu.IsVisible = !frameSagMenu.IsVisible;
        }
    }

}
