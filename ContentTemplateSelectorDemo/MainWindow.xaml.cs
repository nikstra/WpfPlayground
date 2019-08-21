using System.Windows;

namespace ContentTemplateSelectorDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //ContentControl cc = new ContentControl();

            contentControl1.Content = "Border Template String";
            contentControl2.Content = "Two TextBlock Template String";
        }
    }
}
