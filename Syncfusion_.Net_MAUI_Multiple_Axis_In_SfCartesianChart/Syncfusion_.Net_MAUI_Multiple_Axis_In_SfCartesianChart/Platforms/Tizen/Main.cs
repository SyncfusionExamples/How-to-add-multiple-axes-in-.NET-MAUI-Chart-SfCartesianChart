using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Syncfusion_.Net_MAUI_Multiple_Axis_In_SfCartesianChart;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
