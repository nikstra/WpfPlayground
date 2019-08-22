using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TreeViewHierarchicalDataTemplate
{
    public class NodeViewModel : INotifyPropertyChanged
    {
        private string _id;
        public string Id
        {
            get => _id;
            set
            {
                _id = value;
                NotifyPropertyChanged();
            }
        }

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


        private ObservableCollection<NodeViewModel> _children;
        public ObservableCollection<NodeViewModel> Children
        {
            get => _children;
            set
            {
                _children = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
