# How to add multiple axes in .NET MAUI Chart(SfCartesianChart)
This article explains how to add multiple Y-axes in the .NET MAUI charts.
<br><br>
Consider the use case of plotting the graph for two different scenarios with varying unit rates on the same field as shown in the following image. It has been achieved by using the XAxes and YAxes of the SfCartesianChart.
<br>
**Step 1:** Populate the chart with multiple axes. Add multiple axes to the SfCartesianChart.YAxes property. Then, assign the axis Name property for each axis as follows:
<br>
**[XAML]**
```
     <chart:SfCartesianChart.XAxes>
           <chart:DateTimeAxis Name="primaryX"/>
     </chart:SfCartesianChart.XAxes>
     
     <chart:SfCartesianChart.YAxes>
           <chart:NumericalAxis Name="primaryY"/>
           <chart:NumericalAxis Name="secondaryY"/>
     </chart:SfCartesianChart.YAxes>
```
**[C#]**
```
DateTimeAxis xAxis = new DateTimeAxis()
{
     Name = "primaryX",
};
chart.XAxes.Add(xAxis);

NumericalAxis yAxis = new NumericalAxis()
{
     Name = "primaryY",
};
chart.YAxes.Add(yAxis);

NumericalAxis yAxis2 = new NumericalAxis()
{
     Name = "secondaryY",
};
chart.YAxes.Add(yAxis2);
```
**Step 2:** Assign the respective axis to the series. Assign the respective axis name to the series using the cartesian series YAxisName property as follows:
<br>
**[XAML]**
```
    <chart:SfCartesianChart.Series>
           <chart:ColumnSeries  YAxisName="primaryY"/>
           <chart:LineSeries YAxisName="secondaryY"/>
    </chart:SfCartesianChart.Series>
```
**[C#]**
```
ColumnSeries series1 = new ColumnSeries();
Series1.YAxisName = "primaryY";
chart.Series.Add(series1);

LineSeries series2 = new LineSeries();
series2.YAxisName = "secondaryY";
chart.Series.Add(series2);
```
**Step 3:** Position the chart axis. An axis can be positioned anywhere in the chart area by using the CrossesAt property. Set the CrossesAt property as the MaxValue to place the Y axis at the opposite of its actual position.
<br>
**[XAML]**
```
     <chart:SfCartesianChart.YAxes>
           <chart:NumericalAxis Name="primaryY" />
           <chart:NumericalAxis CrossesAt="{Static x:Double.MaxValue}" Name="secondaryY"/>
     </chart:SfCartesianChart.YAxes>
```
**[C#]**
```
NumericalAxis yAxis = new NumericalAxis()
{
     Name = "primaryY",
};
chart.YAxes.Add(yAxis);

NumericalAxis yAxis2 = new NumericalAxis()
{
     Name = "secondaryY",
     CrossesAt = double.MaxValue
};
chart.YAxes.Add(yAxis2);
```
> **_Note:_**
By default, the series are plotted based on the 0th index axis of the XAxes and YAxes collections.
