using System;
using System.Collections.Generic;
using System.IO;
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

namespace ExceptionsInWPF
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



    private void IndexExceptionButton_Click(object sender, RoutedEventArgs e)
    {
      var books = new List<string>();
      books.Add("HLSL and Pixel Shaders for XAML Developers");

      string bookName = books[5]; // try to access an non-existent  item
    }

    private void handlerButton_Click(object sender, RoutedEventArgs e)
    {
      var books = new List<string>();
      books.Add("HLSL and Pixel Shaders for XAML Developers");
      try
      {
        string bookName = books[5]; // try to access an non-existent  item
      }
      catch (ArgumentOutOfRangeException)
      {

        MessageBox.Show("That item doesn't exist. Try another index.");
      }

    }
  }
}
