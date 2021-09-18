using System.Windows;

namespace ExploringBreakpoints {

	public partial class MainWindow : Window {

		public MainWindow() {
			InitializeComponent();
		}

		private void GetNameButton_Click(object sender, RoutedEventArgs e) {
			var gen = new NameGeneratorLib.NameGenerator();
			var maleName = gen.GetMaleName();
		
			outputTextblock.Text = maleName;
		}

		public const int NAME_COUNT = 8;

		private void allNamesButton_Click(object sender, RoutedEventArgs e) {
			var gen = new NameGeneratorLib.NameGenerator();
			var allFemaleNames = gen.GetFemaleNames(8);

			AllNamesListBox.ItemsSource = allFemaleNames;

			//foreach (var item in allMaleNames)
			//{
			//	AllNamesListBox.Items.Add(item);
			//}
		}

		// Learn more about supported code changes
		// for C# Edit and Continue.
		// https://msdn.microsoft.com/en-us/library/ms164927.aspx
	}
}