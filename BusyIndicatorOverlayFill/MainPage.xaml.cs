namespace BusyIndicatorOverlayFill
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.GenerateData();
        }
        public async void GenerateData()
        {
            busyIndicator.IsRunning = true;
            await Task.Delay(4000);
            listView.ItemsSource = new string[] { "James", "Richard", "Clara", "Michael", "Alex", "Clara" };
            await Task.Delay(2000);
            busyIndicator.IsRunning = false;
        }
    }

}
