using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DesignModeData
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<string> People { get; set; }
        //private List<string> _people;
        //public List<string> People
        //{
        //    get => _people;
        //    set
        //    {
        //        _people = value;
        //        NotifyPropertyChanged();
        //    }
        //}

        public MainWindowViewModel()
        {
            People = new ObservableCollection<string>
            {
                "Runtime Data 1",
                "Runtime Data 2",
                "Runtime Data 3"
            };
        }

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
