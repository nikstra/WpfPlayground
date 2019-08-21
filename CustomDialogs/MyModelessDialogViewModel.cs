using WpfCommonLibrary;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CustomDialogs
{
    public class MyModelessDialogViewModel : ViewModelBase
    {
        public ICommand OnMyModelessDialogClosed { get; set; }
        public event EventHandler DialogClosed;

        private string _answer;
        public string Answer
        {
            get => _answer;
            set {
                _answer = value;
                NotifyPropertyChanged();
            }
        }

        private string _question;
        public string Question
        {
            get => _question;
            set
            {
                _question = value;
                NotifyPropertyChanged();
            }
        }

        public MyModelessDialogViewModel()
        {
            OnMyModelessDialogClosed = new RelayCommand(() => DialogClosed(this, EventArgs.Empty));
        }
    }
}
