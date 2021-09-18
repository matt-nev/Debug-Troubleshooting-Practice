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

namespace PerfCounterExample {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();
      this.Loaded += MainWindow_Loaded;
     
    }
    private CounterCreationData _registerMousePerSecond = new CounterCreationData();
   private PerformanceCounter _counter = new PerformanceCounter();
    private void MainWindow_Loaded(object sender, RoutedEventArgs e) {
      // register the counter with windows.
      if (PerformanceCounterCategory.Exists("DebugEssentialTraining"))
      {
        PerformanceCounterCategory.Delete("DebugEssentialTraining");
      }
      
        CounterCreationDataCollection counters = new CounterCreationDataCollection();
        _registerMousePerSecond.CounterName = "Mouse moves / sec";
        _registerMousePerSecond.CounterHelp = "Number of mouse moves executed per second";
        _registerMousePerSecond.CounterType = PerformanceCounterType.RateOfCountsPerSecond32;
        counters.Add(_registerMousePerSecond);

        PerformanceCounterCategory.Create("DebugEssentialTraining", "Example for DebugEssentialTraining", PerformanceCounterCategoryType.SingleInstance,counters);
     

      // create the counter
      _counter.CategoryName = "DebugEssentialTraining";
      _counter.CounterName = "Mouse moves / sec";
      _counter.MachineName = ".";
      _counter.ReadOnly = false;
      _counter.RawValue = 0;
     
      
    }

    private void Grid_MouseMove(object sender, MouseEventArgs e) {
      MessageTextBlock.Text = string.Format ("{0:#0}-{1:#0}",e.GetPosition(this).X, e.GetPosition(this).Y);
      _counter.Increment();
    }
  }
}
