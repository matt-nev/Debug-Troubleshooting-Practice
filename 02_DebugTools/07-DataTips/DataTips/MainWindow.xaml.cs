﻿using System;
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

  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void dataTipsButton_Click(object sender, RoutedEventArgs e)
    {
      ExampleMethod();

    }

    private void ExampleMethod() {
      if (System.Diagnostics.Debugger.IsAttached)
      {
        System.Diagnostics.Debugger.Break();
      }
      // C# primitive variable type (float, double, short, int, long etc..)

      string sentence = "One word after another.";
      double taxRate = 7.8;


      // types with more properties
      var tour = new Tour { TourName = "City bikes", Location = "Portland" };
      var birthDate = DateTime.Parse("5/5/1992");
    

      var sortedNames = new SortedDictionary<string, int>();
      sortedNames.Add("Henry", 45);
      sortedNames.Add("Betsy", 23);
      sortedNames.Add("Wayne", 62);
      sortedNames.Add("Freddie", 38);
      sortedNames.Add("Martin", 55);
      sortedNames.Add("Ralph", 28);

      #region Message
      messageTextBlock.Text = sentence;
      messageTextBlock.Text = taxRate.ToString();

      #endregion
    }
  }

  public class Tour
  {
    public string TourName { get; set; }
    public string Location { get; set; }
  }
}
