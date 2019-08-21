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

namespace DependencyProperties
{
    /// <summary>
    /// Interaction logic for MyUserControl1.xaml
    /// </summary>
    public partial class MyUserControl : UserControl
    {
        public bool IsGreen
        {
            get => (bool)GetValue(IsGreenProperty);
            set => SetValue(IsGreenProperty, value);
        }

        public static readonly DependencyProperty IsGreenProperty = DependencyProperty.Register(
            nameof(IsGreen),
            typeof(bool),
            typeof(MyUserControl),
            new PropertyMetadata(false));

        public MyUserControl()
        {
            InitializeComponent();
        }
    }
}
