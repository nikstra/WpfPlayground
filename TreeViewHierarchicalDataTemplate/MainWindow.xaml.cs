using System.Collections.ObjectModel;
using System.Windows;
using TreeViewHierarchicalDataTemplate.NodeModels;

namespace TreeViewHierarchicalDataTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TreeViewModel TreeModel { get; set; }
        public NodesViewModel NodesModel { get; set; }

        public MainWindow()
        {
            PopulateTree();
            PopulateTree2();
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

        private void PopulateTree2()
        {
            NodesModel = new NodesViewModel
            {
                Nodes = new ObservableCollection<INode>
                {
                    new Node
                    {
                        Name = "Node 1",
                        Nodes = new ObservableCollection<INode>
                        {
                            // Add some different types for the TreeView (Hierarchical)DataTemplates to bind to.
                            new SubNode
                            {
                                Name = "Node 1.1",
                                Nodes = new ObservableCollection<INode>
                                {
                                    new SubLeaf { Name = "Leaf 1.1" }
                                }
                            },
                            new SubLeaf { Name = "Leaf 0.1" },
                            new Leaf { Name = "Leaf 1" },
                            new Leaf { Name = "Leaf 2" },
                            new Leaf { Name = "Leaf 3" }
                        }
                    },
                    new Node
                    {
                        Name = "Node 2",
                        Nodes = new ObservableCollection<INode>
                        {
                            new Node
                            {
                                Name = "Node 3",
                                Nodes = new ObservableCollection<INode>
                                {
                                    new Leaf { Name = "Leaf 1" },
                                    new Leaf { Name = "Leaf 2" },
                                    new Leaf { Name = "Leaf 3" }
                                }
                            },
                            new Leaf { Name = "Leaf 1" },
                            new Leaf { Name = "Leaf 2" },
                            new Leaf { Name = "Leaf 3" }
                        }
                    },
                    new Leaf { Name = "Leaf 1" },
                    new Leaf { Name = "Leaf 2" },
                    new Leaf { Name = "Leaf 3" }
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
