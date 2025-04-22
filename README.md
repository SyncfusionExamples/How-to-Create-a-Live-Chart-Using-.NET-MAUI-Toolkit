# How to Create a Live Chart Using .NET MAUI Toolkit?

This repository contains a sample project showcasing how to create a live chart using [.NET MAUI Cartesian Chart](https://www.syncfusion.com/maui-controls/maui-cartesian-charts). 

**Step 1:** Initialize the [SfCartesianChart](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.SfCartesianChart.html) with a fixed set of data points representing an ECG waveform.

**Step 2:** Use a timer [IDispatcherTimer](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.dispatching.idispatchertimer?view=net-maui-9.0) to update the chart data every 100 milliseconds (10Hz), simulating a real-time data feed.

**Step 3:** Bind the chart’s [FastLineSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.FastLineSeries.html?tabs=) to an ObservableCollection that gets updated with new data points while removing the oldest ones to maintain a constant count.

**Step 4:** Configure the X and Y axes using [NumericalAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html?tabs=) and display amplitude vs. sample index.

**Step 5:** Manage chart lifecycle by starting the timer in [OnAppearing](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.page.onappearing?view=net-maui-9.0) and stopping it in OnDisappearing to ensure optimal performance and avoid memory leaks.

**Step 6:** Manage chart lifecycle by starting the timer in OnAppearing and stopping it in [OnDisappearing](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.page.ondisappearing?view=net-maui-9.0) to ensure optimal performance and avoid memory leaks.



## Troubleshooting

### Path Too Long Exception

If you are facing a "Path too long" exception when building this example project, close Visual Studio and rename the repository to a shorter name before building the project.

Refer to the KB article on [how to use DateTime values in the Y Axis in .NET MAUI Cartesian Chart](https://support.syncfusion.com/kb/article/19837/how-to-use-datetime-values-in-the-y-axis-in-net-maui-cartesian-chart) for better understanding along with relevant code snippets.
