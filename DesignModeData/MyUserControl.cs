using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace DesignModeData
{
    /// <summary>
    /// Interaction logic for MyUserControl.xaml
    /// </summary>
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();

            // A couple of ways to determine if we are in design mode.
            if (DesignerProperties.GetIsInDesignMode(this))
            {
                MyTextBlock.Text += Environment.NewLine + "Design mode check 1";
            }

            if ((bool)(DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(DependencyObject)).DefaultValue))
            {
                MyTextBlock.Text += Environment.NewLine + "Design mode check 2";
            }

            if (System.Reflection.Assembly.GetExecutingAssembly().Location.Contains("VisualStudio"))
            {
                MyTextBlock.Text += Environment.NewLine + "Design mode check 3";
            }
        }
    }
}
