using System.Collections.ObjectModel;
using System.Windows;

namespace TabThroughListViewUserControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ObservableCollection<KeyValue> DesignData => CreateData();
        public ObservableCollection<KeyValue> KeyValues { get; set; }
        public MainWindow()
        {
            KeyValues = CreateData();
            DataContext = this;

            InitializeComponent();
        }

        private static ObservableCollection<KeyValue> CreateData() =>
            new ObservableCollection<KeyValue>
            {
                new KeyValue { Key = "Given Name:", Value = "Niklas" },
                new KeyValue { Key = "Surname:", Value = "Strand" },
                new KeyValue { Key = "Username:", Value = "nikstra" }
            };
    }
}
