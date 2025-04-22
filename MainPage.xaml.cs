using Microsoft.Maui.Controls;

namespace RealTimeChart
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
            // Stop any existing timer first
            realTimeChartViewModel.StopTimer();
            
            // Start the timer to update the chart
            realTimeChartViewModel.StartTimer();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            
            // Make sure to stop the timer when leaving the page
            if (realTimeChartViewModel != null)
            {
                realTimeChartViewModel.StopTimer();
            }
            
            // Properly disconnect the chart handler to avoid memory leaks
            realTimeChart.Handler?.DisconnectHandler();
        }
    }
}


