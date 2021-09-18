using System.Windows;

namespace Demo {

  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();
    }

    private void steppingButton_Click(object sender, RoutedEventArgs e) {
      decimal monthlyPayment;
      decimal rate = 5.6M;

      // step into
      monthlyPayment = Financial.CalculateMonthlyPayment(12, rate, 1200);

      // step over
      monthlyPayment = Financial.CalculateMonthlyPayment(24, rate, 2400);

      // step out;
      monthlyPayment = Financial.CalculateMonthlyPayment(12, rate, 1800);

    }






  }
}
