using System.Collections.ObjectModel;
using System.Windows;

namespace TreeViewHierarchicalDataTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TreeViewModel TreeModel { get; set; }

        public MainWindow()
        {
            PopulateTree();
            InitializeComponent();
        }

        private void PopulateTree()
        {
            TreeModel = new TreeViewModel
            {
                Items = new ObservableCollection<NodeViewModel>
                    {
                        new NodeViewModel
                        {
                            Name = "Root", Children =  new ObservableCollection<NodeViewModel>
                            {
                                new NodeViewModel
                                {
                                    Name = "Level1" ,  Children = new ObservableCollection<NodeViewModel>
                                    {
                                        new NodeViewModel{ Name = "Level2"}
                                    }
                                }
                            }
                        }
                    }
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var children = new ObservableCollection<NodeViewModel>();
            children.Add(
                new NodeViewModel
                {
                    Name = "Level3",
                }
            );

            TreeModel.Items[0].Children[0].Children[0].Children = children;
        }
    }
}
