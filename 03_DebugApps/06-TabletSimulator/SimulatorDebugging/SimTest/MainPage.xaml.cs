using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SimTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
      this.SizeChanged += MainPage_SizeChanged;
        }

    private void MainPage_SizeChanged(object sender, SizeChangedEventArgs e) {
      CurrentLayoutTextBlock.Text = "Layout Updated at :" + DateTime.Now.ToString("T");
    }

    private void Image1_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e) {
      Transform1.ScaleX = Transform1.ScaleY = e.Cumulative.Scale;
    }

    private void Image2_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e) {

      Transform2.Rotation = e.Cumulative.Rotation;
    }
    private Point _startPoint;
    private void Image2_ManipulationStarted(object sender, ManipulationStartedRoutedEventArgs e) {
      _startPoint = e.Position;
    }
 
  }
}
