using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinTrail {
  public partial class FirstPage : ContentPage {
    public FirstPage() {
      InitializeComponent();
      this.SizeChanged += FirstPage_SizeChanged;
    }

    private void FirstPage_SizeChanged(object sender, EventArgs e) {
      orientationLabel.Text = IsPortrait(this) ? "Portrait Mode" : "Landscape";
      var platform = DeviceInfo.Plugin.CrossDeviceInfo.Current.Platform;
      deviceLabel.Text = "Current Device: " + platform;

    }

    int _counter;
    public void Button_Clicked(object sender, EventArgs e) {
      _counter += 1;
      messageLabel.Text = String.Format("Wildlife sighted {0} times", _counter);

    }
    static bool IsPortrait(Page p) { return p.Width < p.Height; }
  }
}
