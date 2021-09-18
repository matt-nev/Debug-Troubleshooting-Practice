using AttachToRunningApp.Pages;
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

namespace AttachToRunningApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			ContentFrame.Navigate(new Uri("Pages/EntryPage.xaml", UriKind.Relative));

		}

		private void EntryButton_Click(object sender, RoutedEventArgs e)
		{
			ContentFrame.Navigate(new Uri("Pages/EntryPage.xaml", UriKind.Relative));
		}

		private void DetailsButton_Click(object sender, RoutedEventArgs e)
		{
			ContentFrame.Navigate(new Uri("Pages/DetailsPage.xaml", UriKind.Relative));
		}

	

		private void TimeButton_Click(object sender, RoutedEventArgs e)
		{
			MessageTextBox.Text = DateTime.Now.ToLongDateString();
		}
	}
}
