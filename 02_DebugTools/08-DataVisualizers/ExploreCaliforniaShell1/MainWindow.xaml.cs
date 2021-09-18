
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExploreCaliforniaShell1
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

		private void EntryButton_Click(object sender, RoutedEventArgs e)
		{
      if (System.Diagnostics.Debugger.IsAttached)
      {
        System.Diagnostics.Debugger.Break();
      }
			this.DetailsButton.Width = 300;

		}

		private void DetailsButton_Click(object sender, RoutedEventArgs e)
		{
		
		}

		private void ReportsButton_Click(object sender, RoutedEventArgs e)
		{
			
		}
	}
}
