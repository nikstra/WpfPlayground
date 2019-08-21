using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;
using WpfCommonLibrary;

namespace Animations
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _overlayVisible;
        public bool OverlayVisible
        {
            get => _overlayVisible;
            set
            {
                _overlayVisible = value;
                NotifyPropertyChanged();
            }
        }

        public ICommand EscapeKeyCommand { get; set; }
        public ICommand AltEnterKeyCommand { get; set; }

        public MainWindow()
        {
            
            InitializeComponent();
            DataContext = this;
            OverlayVisible = true;
            EscapeKeyCommand = new RelayCommand(() =>
            {
                OverlayVisible = false;
            });
            AltEnterKeyCommand = new RelayCommand(() =>
            {
                OverlayVisible = true;
            });
        }

        // TODO: Remove unused event handlers.
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (true) //txtPassword.Text != "correct password")
            {
                Storyboard myStoryboard = (Storyboard)txtPassword.Resources["TestStoryboard"];
                //Storyboard.SetTarget(myStoryboard.Children.ElementAt(0) as DoubleAnimationUsingKeyFrames, txtPassword);
                Storyboard.SetTarget(myStoryboard.Children.ElementAt(0) as DoubleAnimation, txtPassword);
                myStoryboard.Begin();
            }
        }

        private void TheButton2_Click(object sender, RoutedEventArgs e)
        {
            if (true) //txtPassword.Text != "correct password")
            {
                Storyboard myStoryboard = (Storyboard)txtPassword2.Resources["TestStoryboard2"];
                Storyboard.SetTarget(myStoryboard.Children.ElementAt(0) as DoubleAnimationUsingKeyFrames, txtPassword2);
                //Storyboard.SetTarget(myStoryboard.Children.ElementAt(0) as DoubleAnimation, txtPassword2);
                myStoryboard.Begin();
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
