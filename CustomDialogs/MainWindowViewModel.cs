using WpfCommonLibrary;
using System;
using System.Windows;
using System.Windows.Input;

namespace CustomDialogs
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IWindowManager _viewManager = new WindowManager();

        public ICommand ShowModalDialog { get; set; }
        public ICommand ShowModelessDialog { get; set; }

        public MainWindowViewModel()
        {
            ShowModalDialog = new RelayCommand(o =>
            {
                var vm = new MyModalDialogViewModel
                {
                    Question = "Question:"
                };
                if (_viewManager.ShowModalDialog(vm, o) == true)
                {
                    MessageBox.Show(vm.Answer);
                }
            });
            ShowModelessDialog = new RelayCommand(ShowModelessDlg);
        }

        private void ShowModelessDlg()
        {
            var vm = new MyModelessDialogViewModel
            {
                Question = "Am I modeless?"
            };
            vm.DialogClosed += MyModelessDialog_Closed;
            _viewManager.ShowModelessDialog(vm);
        }

        private void MyModelessDialog_Closed(object sender, EventArgs e)
        {
            // TODO: Don't show the MessageBox on app exit. Catch only dialog close.
            if(sender is MyModelessDialogViewModel vm)
            {
                MessageBox.Show(vm.Answer);
            }
        }
    }
}
