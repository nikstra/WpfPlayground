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

namespace TabThroughListViewUserControl
{
    /// <summary>
    /// Interaction logic for KeyValueControl.xaml
    /// </summary>
    public partial class KeyValueControl : UserControl
    {
        /// <summary>
        /// Sets the width of all TextBoxes in the KeyValueControl.
        /// </summary>
        public int TextBoxWidth
        {
            get { return (int)GetValue(TextBoxWidthProperty); }
            set { SetValue(TextBoxWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextBoxWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextBoxWidthProperty =
            DependencyProperty.Register("TextBoxWidth", typeof(int), typeof(KeyValueControl), new PropertyMetadata(0));


        public KeyValueControl()
        {
            InitializeComponent();
        }
    }
}
