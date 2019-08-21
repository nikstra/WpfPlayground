using Microsoft.CSharp.RuntimeBinder;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows;
using System.Windows.Input;

namespace UsernamePassword
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private SecureString Password = new SecureString();

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand PasswordChangedCommand { get; set; }
        public ICommand LoginCommand { get; set; }

        public MainWindowViewModel()
        {
            PasswordChangedCommand = new RelayCommand(c => true, this.OnPasswordChanged);
            LoginCommand = new RelayCommand(c => true, e => MessageBox.Show(Password.ConvertToUnsecureString()));
        }

        private void OnPasswordChanged(dynamic passwordObject)
        {
            if(passwordObject != null)
            {
                try
                {
                    Password = passwordObject.SecurePassword;
                }
                catch(RuntimeBinderException /*ex*/)
                {
                    // TODO: It would be of limited use to do anything here unless we are in development. Maybe an #if DEBUG.
                }
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
