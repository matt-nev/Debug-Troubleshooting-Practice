using System.Diagnostics;
using System.Windows;

namespace ExampleApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void watchButton_Click(object sender, RoutedEventArgs e)
		{
			

			// variable for watch

			string greeting;
			greeting = "hell0";
			var book = new Book { Author = "Walt Ritscher", Title = "Secrets of Visual Studio 2015", Price = 55M };

			double markupPercent = 1.2;
      markupPercent = 2.5;

      // add some adhoc items
      // MainCalender,  
      var currentDate = MainCalendar.SelectedDate;
      if (Debugger.IsAttached)
      {
        Debugger.Break();
      }
    }

		private void MoreWatchButton_Click(object sender, RoutedEventArgs e)
		{
			
			// add more watch windows
			var book = new Book { Author = "Sabrina Shugarac", Title = "Ten Tips for Success", Price = 13.33M };


      if (Debugger.IsAttached)
      {
        Debugger.Break();
      }
    }
	}
}