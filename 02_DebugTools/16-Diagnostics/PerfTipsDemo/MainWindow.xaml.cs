using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace PerfTipsDemo {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}
		private NameGeneratorLib.NameGenerator _nameGen = new NameGeneratorLib.NameGenerator();

		private  void FemaleNamesButton_Click(object sender, RoutedEventArgs e) {
			var femaleNames =  _nameGen.GetFemaleNames(8);
			FemaleNamesListBox.ItemsSource = femaleNames;
		}

		private void MaleNameButton_Click(object sender, RoutedEventArgs e) {
			var maleName = _nameGen.GetMaleName();
			SingleName1.Text = maleName;
		}

		private void FemaleNameButton_Click(object sender, RoutedEventArgs e) {
			var femaleName = _nameGen.GetFemaleName();
			SingleName2.Text = femaleName;
		}

		private async void MaleNamesButton_Click(object sender, RoutedEventArgs e) {

			
			var maleNames = await _nameGen.GetMaleNames(8);
			MaleNamesListBox.ItemsSource = maleNames;
		}
	}
}
