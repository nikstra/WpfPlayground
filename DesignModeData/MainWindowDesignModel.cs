using System.Collections.ObjectModel;

namespace DesignModeData
{
    public class MainWindowDesignModel : MainWindowViewModel
    {
        public static MainWindowDesignModel CreateInstance => new MainWindowDesignModel();

        public MainWindowDesignModel()
        {
            People = new ObservableCollection<string>
            {
                "Donald Duck",
                "Garfield",
                "Goofy",
                "Homer Simpson"
            };
        }
    }
}
