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
using System.Windows.Shapes;

namespace CustomDialogs
{
    /// <summary>
    /// Interaction logic for MyModalDialog.xaml
    /// </summary>
    public partial class MyModalDialogView : Window
    {
        public string Answer => answerTextBox.Text;

        //public MyModalDialogView(MyModalDialogViewModel viewModel)
        //    : this("Default?", "Yes") =>
        //    DataContext = viewModel ?? throw new ArgumentNullException(nameof(viewModel));

        //public MyModalDialogView(string question, string defaultAnswer = "")
        public MyModalDialogView()
        {
            InitializeComponent();
            //questionLabel.Content = question;
            //answerTextBox.Text = defaultAnswer;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e) => DialogResult = true;

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            answerTextBox.SelectAll();
            answerTextBox.Focus();
        }
    }
}
