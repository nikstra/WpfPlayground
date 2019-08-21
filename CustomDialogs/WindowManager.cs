using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CustomDialogs
{
    // TODO: Move to WpfLibrary project.
    public class WindowManager : IWindowManager
    {
        private static readonly string viewModelNameSuffix = "ViewModel";
        private static readonly string viewNameSuffix = "View";
        public IEnumerable<string> ViewNamespaces { get; private set; }

        public WindowManager()
        {
            ViewNamespaces = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Select(t => t.Namespace).Distinct();
        }

        public WindowManager(string viewNamespace)
        {
            if (string.IsNullOrWhiteSpace(viewNamespace))
            {
                throw new ArgumentException("A namespace is requiered", nameof(viewNamespace));
            }

            ViewNamespaces = new[] { viewNamespace };
        }

        public WindowManager(IEnumerable<string> viewNamespaces)
        {
            ViewNamespaces = viewNamespaces ?? throw new ArgumentNullException(nameof(viewNamespaces));
            if (!ViewNamespaces.Any())
            {
                throw new ArgumentException("Collection cannot be empty", nameof(viewNamespaces));
            }
        }

        public bool? ShowModalDialog(ViewModelBase viewModel, object owner = null)
        {
            var view = CreateWindowInstance(viewModel, owner);
            return view.ShowDialog();
        }

        public void ShowModelessDialog(ViewModelBase viewModel, object owner = null)
        {
            var view = CreateWindowInstance(viewModel, owner);
            view.Show();
        }

        private Window CreateWindowInstance(ViewModelBase viewModel, object owner)
        {
            var viewModelName = viewModel.GetType().Name;
            var viewName = GetViewNameFromViewModelName(viewModelName);
            Type viewType = ViewNamespaces
                .Select(n => Type.GetType($"{n}.{viewName}"))
                .First(t => t != null);

            var view = (Window)Activator.CreateInstance(viewType);
            view.Owner = owner as Window ?? Application.Current.MainWindow;
            view.DataContext = viewModel;

            return view;
        }

        private string GetViewNameFromViewModelName(string viewModelName)
        {
            int position = viewModelName.LastIndexOf(viewModelNameSuffix);
            if (position < 1)
            {
                throw new ApplicationException($"Invalid viewmodel name: {viewModelName}");
            }
            return viewModelName.Substring(0, position) + viewNameSuffix;
        }
    }
}
