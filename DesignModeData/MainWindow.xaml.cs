using System.ComponentModel;
using System.Windows;

namespace DesignModeData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // When opened in the designer, the MainWindow is not instantiated
            // (constructor is not called). Thus this if statement will never be true.
            if (DesignerProperties.GetIsInDesignMode(this)) { /* Code here will not run */ }

            // TODO: Find documentation that supports this. So far I've only found
            // documentation that states that a UserControl is instantiated by the
            // designer. For that reason I've created MyUserControl to demonstrate
            // how to check if in design mode.
        }
    }
}
