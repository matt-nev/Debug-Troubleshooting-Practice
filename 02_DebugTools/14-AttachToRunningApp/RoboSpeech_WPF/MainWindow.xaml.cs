using System.Speech.Synthesis;
using System.Windows;

namespace BasicApp_WPF {

  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {

    public MainWindow() {
      InitializeComponent();

      synth.SpeakProgress += Synth_SpeakProgress;
    }

    private void Synth_SpeakProgress(object sender, SpeakProgressEventArgs e) {
      messageTextBlock.Text = e.Text;
    }

    private static SpeechSynthesizer synth = new System.Speech.Synthesis.SpeechSynthesizer();

    private void MaleButton_Click(object sender, RoutedEventArgs e) {
      synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
      synth.SpeakAsync(inputText.Text);
    }

    private void FemaleButton_Click(object sender, RoutedEventArgs e) {
      synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
      synth.SpeakAsync("Lorem ipsum dolor sit amet");
    }
  }
}