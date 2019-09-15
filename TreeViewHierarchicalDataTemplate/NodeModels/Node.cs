using System.Collections.ObjectModel;

namespace TreeViewHierarchicalDataTemplate.NodeModels
{
    public class Node : Leaf
    {
        private ObservableCollection<INode> _nodes;

        public ObservableCollection<INode> Nodes
        {
            get => _nodes;
            set
            {
                _nodes = value;
                NotifyPropertyChanged();
            }
        }
    }
}
