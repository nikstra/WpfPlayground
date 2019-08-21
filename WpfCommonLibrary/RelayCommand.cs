using System;
using System.Windows.Input;

namespace WpfCommonLibrary
{
    public class RelayCommand : ICommand
    {
        private readonly Predicate<object> _canExecute;
        private readonly Action<object> _execute;

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public RelayCommand(Action action)
            : this(action, _ => true)
        {
        }

        public RelayCommand(Action action, Predicate<object> predicate)
            : this(_ => action(), predicate)
        {
        }

        public RelayCommand(Action<object> action)
            : this(action, _ => true)
        {
        }

        public RelayCommand(Action<object> action, Predicate<object> predicate)
        {
            _execute = action ?? throw new ArgumentNullException(nameof(action));
            _canExecute = predicate ?? throw new ArgumentNullException(nameof(predicate));
        }

        public bool CanExecute(object parameter) => _canExecute(parameter);

        public void Execute(object parameter) => _execute(parameter);
    }
}
