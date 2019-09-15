using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TreeViewHierarchicalDataTemplate.NodeModels
{
    public class Leaf : INode
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
