using Syncfusion.Maui.Charts;

namespace SampleDemo;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        //SfCartesianChart chart = new SfCartesianChart();
        //chart.BindingContext = new ViewModel();
        ////Initializing XAxes
        //CategoryAxis xAxis = new CategoryAxis();
        //chart.XAxes.Add(xAxis);

        ////Initializing YAxes
        //NumericalAxis yAxis = new NumericalAxis();
        //yAxis.Name = "yAxis1";
        //chart.YAxes.Add(yAxis);

        //NumericalAxis yAxis2 = new NumericalAxis()
        //{
        //    Name = "yAxis2",
        //    CrossesAt = double.MaxValue
        //};

        //chart.YAxes.Add(yAxis2);

        //ColumnSeries series1 = new ColumnSeries();
        //chart.Series.Add(series1);
        //series1.ItemsSource = (new ViewModel().Data);
        //series1.XBindingPath = "Months";
        //series1.YBindingPath = "Temperature1";
        //series1.EnableTooltip = true;

        //LineSeries series2 = new LineSeries();
        //series2.YAxisName = "yAxis2";
        //series2.ItemsSource = (new ViewModel().Data);
        //series2.XBindingPath = "Months";
        //series2.YBindingPath = "Temperature2";
        //series2.EnableTooltip = true;


        //chart.Series.Add(series2);

        //this.Content = chart;
    }
}

