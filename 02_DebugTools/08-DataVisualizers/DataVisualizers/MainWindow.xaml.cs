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

namespace DataTipsAndDataVisualizers
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


    private void dataVisualizerButton_Click(object sender, RoutedEventArgs e)
    {
      if (System.Diagnostics.Debugger.IsAttached)
      {
        System.Diagnostics.Debugger.Break();
      }
      string sentence = "short strings are okay in data tips";
      string htmlString = "<h2>New Bike Tour added</h2>";

      // Debug Visualizer AKA Data Visualizer
      // provide alternate ways to view string data
      // in the debugger.
      string xmlContent = System.IO.File.ReadAllText("fleet.xml");
      string textContent = System.IO.File.ReadAllText("mit-License.txt");
      string htmlContent = System.IO.File.ReadAllText("htmlpage.txt");
      string jsonContent = System.IO.File.ReadAllText("customer.json");



      var result = sentence;
      result = htmlString;
    }


  }
}
