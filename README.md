# Create Real-Time ECG Monitoring with .NET MAUI & Syncfusion Charts

Discover how to build a real-time ECG monitoring application using .NET MAUI and [SfCartesianChart](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.SfCartesianChart.html). This guide walks you through creating a responsive, live-updating visualization that's perfect for medical applications, IoT dashboards, or any scenario requiring real-time data visualization.

## Overview

Real-time data visualization is essential in many modern applications, from healthcare monitoring to stock market tracking. This project demonstrates how to leverage .NET MAUI and Syncfusion's chart components to create a smooth, efficient ECG monitor that updates at 100Hz with realistic waveform patterns.

The sample application shows how to implement a scrolling time-series chart that continuously updates with new data points while maintaining performance across all platforms. Whether you're developing medical software, IoT dashboards, or financial applications, this project provides the foundation for building sophisticated real-time visualizations.

## Key Features

### Smooth Real-Time Updates
- 100Hz refresh rate (1000ms updates) with smooth animation
- Scrolling window showing the most recent 100 data points
- Efficient rendering using FastLineSeries for optimal performance

### Realistic ECG Simulation
- Pattern-based waveform generation with randomization
- Configurable baseline and amplitude
- Characteristic P-QRS-T wave pattern simulation

### Cross-Platform Performance
- Works consistently across Windows, Android, iOS, and macOS
- Maintains frame rate even with rapid updates
- Thread-safe implementation

## Technologies Used

- **.NET MAUI** � Cross-platform app framework
- **Syncfusion� .NET MAUI Components** � [SfCartesianChart](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.SfCartesianChart.html) with FastLineSeries
- **MVVM Pattern** � Clean architecture with ObservableCollection for live data
- **C# & XAML** � UI + logic

## Syncfusion Controls Used

This project leverages Syncfusion's high-performance charting controls:

- **[SfCartesianChart](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.SfCartesianChart.html)** � Base chart control with excellent rendering performance
- **[FastLineSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.FastLineSeries.html?tabs=)** � Optimized for high-frequency data updates

## Troubleshooting

### Path Too Long Exception

If you are facing a "Path too long" exception when building this example project, close Visual Studio and rename the repository to a shorter name before building the project.

Refer to the KB article on [How to create a live chart using .NET MAUI Toolkit?](https://support.syncfusion.com/agent/kb/19960) for better understanding along with relevant code snippets.