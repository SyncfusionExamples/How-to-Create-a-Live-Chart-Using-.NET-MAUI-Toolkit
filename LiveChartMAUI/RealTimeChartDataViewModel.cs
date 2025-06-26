using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Maui.Dispatching;

namespace RealTimeChart
{
    public class RealTimeChartViewModel : INotifyPropertyChanged
    {
        #region Fields
        private ObservableCollection<ChartDataModel> liveData;
        private readonly Random randomValue;
        private IDispatcherTimer? timer;
        private int dataIndex = 0;
        private readonly int maxDataPoints = 100;
        #endregion

        #region Constructor
        public RealTimeChartViewModel()
        {
            randomValue = new Random();
            liveData = new ObservableCollection<ChartDataModel>();
            InitializeDataPoints();
        }
        #endregion

        #region Properties
        public ObservableCollection<ChartDataModel> LiveData
        {
            get { return liveData; }
            set
            {
                liveData = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Methods
        private void InitializeDataPoints()
        {
            LiveData.Clear();
            dataIndex = 0;

            // Initialize with some starting data points
            for (int i = 0; i < maxDataPoints; i++)
            {
                double yValue = GetNextECGValue();
                LiveData.Add(new ChartDataModel { Value = i, Size = yValue });
                dataIndex++;
            }
        }

        private double GetNextECGValue()
        {
            // Simulate ECG pattern - this is a simplified version
            double baseValue = 800;
            int phase = dataIndex % 20;

            if (phase == 0)
                return baseValue + randomValue.Next(10, 20);
            else if (phase == 1)
                return baseValue - randomValue.Next(50, 100);
            else if (phase == 2)
                return baseValue + randomValue.Next(200, 300);
            else if (phase == 3)
                return baseValue - randomValue.Next(150, 250);
            else if (phase == 4)
                return baseValue + randomValue.Next(50, 100);
            else
                return baseValue + randomValue.Next(-20, 20);
        }

        public void StartTimer()
        {
            if (timer == null)
            {
                // Update 10 times per second (100ms)
                timer = Dispatcher.GetForCurrentThread().CreateTimer();
                timer.Interval = TimeSpan.FromMilliseconds(100);
                timer.Tick += Timer_Tick;
                timer.Start();
            }
        }

        public void StopTimer()
        {
            if (timer != null)
            {
                timer.Stop();
                timer = null;
            }
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (LiveData.Count > 0)
            {
                // Remove first item
                LiveData.RemoveAt(0);

                // Add new value at the end
                LiveData.Add(new ChartDataModel
                {
                    Value = dataIndex,
                    Size = GetNextECGValue()
                });

                dataIndex++;
            }
        }
        #endregion

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
