using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SetStyleFromCodeBehind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Resources.Add(typeof(Button), CreateButtonStyle());
        }

        private Style CreateButtonStyle()
        {
            var gradientStops = new GradientStopCollection
            {
                new GradientStop(Color.FromRgb(0x90, 0xDD, 0xDD), 0.0),
                new GradientStop(Color.FromRgb(0x5B, 0xFF, 0xFF), 1.0)
            };

            var brush = new LinearGradientBrush
            {
                StartPoint = new Point(0.5, 0),
                EndPoint = new Point(0.5, 1),
                GradientStops = gradientStops
            };

            var buttonStyle = new Style(typeof(Button));
            buttonStyle.Setters.Add(new Setter(Button.PaddingProperty, new Thickness(20)));
            buttonStyle.Setters.Add(new Setter(Button.FontSizeProperty, 16d));
            buttonStyle.Setters.Add(new Setter(Button.BackgroundProperty, brush));

            return buttonStyle;
        }
    }
}
