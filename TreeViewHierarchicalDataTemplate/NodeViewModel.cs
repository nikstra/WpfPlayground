using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using WpfCommonLibrary;

namespace TreeViewHierarchicalDataTemplate
{
    public class NodeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand OnNodeExpand { get; set; }

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

        public NodeViewModel()
        {
            OnNodeExpand = new RelayCommand(() =>
            {
                if(Children == null)
                {
                    Children = new ObservableCollection<NodeViewModel>();
                }

                Children.Add(new NodeViewModel
                {
                    Name = "New Level " + Children.Count,
                });
            });
        }

        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
