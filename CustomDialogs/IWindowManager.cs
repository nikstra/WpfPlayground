using System.Collections.Generic;

namespace CustomDialogs
{
    // TODO: Move to WpfLibrary project.
    public interface IWindowManager
    {
        IEnumerable<string> ViewNamespaces { get; }

        bool? ShowModalDialog(ViewModelBase viewModel, object owner = null);
        void ShowModelessDialog(ViewModelBase viewModel, object owner = null);
    }
}