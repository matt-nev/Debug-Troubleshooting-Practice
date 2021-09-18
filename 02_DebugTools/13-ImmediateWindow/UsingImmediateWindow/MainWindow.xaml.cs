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

		private void ImmediateButton_Click(object sender, RoutedEventArgs e)
		{
			

      // call items from the Immediate Window
      var book = new Book { Author = "Walt Ritscher",
                            Title = "Stardust", Price = 15.99M };
      var birthDate = DateTime.Parse("12/11/1992");

      if (System.Diagnostics.Debugger.IsAttached)
      {
        System.Diagnostics.Debugger.Break();
      }
    }
	}
}
