using System.Collections.ObjectModel;

namespace CustomDialogs
{
    public class MyModalDialogViewModel : ViewModelBase
    {
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
    }
}
