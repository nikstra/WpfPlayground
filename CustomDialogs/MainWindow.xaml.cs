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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomDialogs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WindowManager _viewManager = new WindowManager();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

        private void ShowModalDialogButton_Click(object sender, RoutedEventArgs e)
        {
            var vm = new MyModalDialogViewModel();
            _viewManager.ShowModalDialog(vm, this);
            //return;
            //var dialog = new MyModalDialogView("What?") { Owner = this };
            //if (dialog.ShowDialog() == true)
            //{
            //    MessageBox.Show(dialog.Answer);
            //}
        }

        private void ShowModelessDialogButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
