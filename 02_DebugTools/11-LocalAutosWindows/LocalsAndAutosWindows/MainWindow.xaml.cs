using System;
using System.Diagnostics;
using System.Windows;

namespace LocalsAndAutosWindows
{

	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

    private void RunButton_Click(object sender, RoutedEventArgs e)
    {
      if (Debugger.IsAttached)
      {
        Debugger.Break();
      }
      WorkWithBook();
    }

    private void WorkWithBook()
    {
      string greeting;
      greeting = "Good day";
      messageTextBlock.Text = greeting;
      var book = new Book { Author = "Walt Ritscher",
                            Title = "How to make $1,000 per day with Visual Studio",
                            Price = 55M };
      
        var taxRate = 1.2;
        taxRate = 2.5;
        messageTextBlock.Text = taxRate.ToString();
     
      WorkWithXmlData("fleet.xml", true);
     
     
    }

		private void WorkWithXmlData(string xmlFileName, bool useSchema)
		{
			// the locals and Autos window will show
			// variables from this method

			var doc = System.Xml.Linq.XDocument.Load(xmlFileName);
			string text = doc.ToString();
		}

   
  }
}