using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.IO;
using System.Xml.Linq;

namespace ExploringBreakpoints {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}



		private void simpleButton_Click(object sender, RoutedEventArgs e) {
			string computerName;
			computerName = "Webserver14";
			var outputText = "The current computer name is " + computerName;
			outputTextblock.Text = outputText;
		}

		private void breakButton_Click(object sender, RoutedEventArgs e) {


			double x;
			x = 6;
			double y = 7;
			// breakpoints cannot be set on comments
      // or other non-runnable lines
			string result;
			double fraction = x / 5;
			result = String.Format("Your answer is {0}", fraction);
			outputTextblock.Text = result;
		}


	}
}
