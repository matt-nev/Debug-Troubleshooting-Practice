using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
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

namespace DebugPhilosophy {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();
    }



    private void Bug1Button_Click(object sender, RoutedEventArgs e) {
      BugA.ShowBug();
    }


    private void Bug2Button_Click(object sender, RoutedEventArgs e) {
      BugB.ShowBug();
    }
    private void ShowBuggy_Click(object sender, RoutedEventArgs e) {
      (new BuggyWindow()).Show();
    }

    private string GetFileNameFromUser() {
      return "catalog.txt";
    }

    private void ErrorButton_Click(object sender, RoutedEventArgs e) {

      

      string fileName = GetFileNameFromUser();
      try
      {
          FileSecurity fs = File.GetAccessControl(fileName);
      }
      catch (FileNotFoundException ex)
      {

        MessageBox.Show(String.Format("The  file ({0}) doesn't exist.",ex.Message),"Error...");
      }
     
    }
  }
}
