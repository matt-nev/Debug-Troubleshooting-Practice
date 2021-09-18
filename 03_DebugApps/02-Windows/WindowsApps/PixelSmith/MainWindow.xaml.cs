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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PixelSmith {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		
			this.Loaded += MainWindow_Loaded;
		}

		private void MainWindow_Loaded(object sender, RoutedEventArgs e) {
			mainImage.MouseMove += MainImage_MouseMove;
		}

		private void MainImage_MouseMove(object sender, MouseEventArgs e) {

			// breakpoints in mouse event are troublesome
			// every time the mouse moves, the breakpoint is hit

			var positionString = String.Format( "{0:#000} - {1:#000}", 
																					e.GetPosition(mainImage).X, 
																					e.GetPosition(mainImage).Y);
			PostionTextBlock.Text = positionString;

			line1.X1 = e.GetPosition(this).X;
			line1.Y1 = 0;

			line1.X2 = line1.X1;
			line1.Y2 = mainImage.ActualHeight;

			line2.X1 = 0;
			line2.Y1 = e.GetPosition(this).Y;

			line2.X2 = mainImage.ActualWidth;
			line2.Y2 = line2.Y1;


		}

		private static Random _random = new Random();
		

		private void ColorToneMenu_Click(object sender, RoutedEventArgs e) {
			var effect = new PixelSmith.Effects.ColorToneEffect();

			effect.DarkColor = Colors.Orange;
			effect.LightColor = Colors.AliceBlue;
			
			mainImage.Effect = effect;
		}

		private void ToonMenu_Click(object sender, RoutedEventArgs e) {
			var effect = new PixelSmith.Effects.ToonShaderEffect();

			effect.Levels = 5;

			mainImage.Effect = effect;
		}

		private void MonochromeMenu_Click(object sender, RoutedEventArgs e) {
			var effect = new PixelSmith.Effects.MonochromeEffect();

			effect.FilterColor = Colors.Tan;

			mainImage.Effect = effect;
		}

		
	}
}
