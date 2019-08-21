using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace UIVirtualization
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private static Random _random = new Random();

        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<string> StringList { get; set; }

        private string _elapsedTime = "0";
        public string ElapsedTime
        {
            get => _elapsedTime;
            set
            {
                _elapsedTime = value;
                NotifyPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            StringList = new ObservableCollection<string>();
            Span<string> span = loremIpsumSentences;

            var t = Stopwatch.StartNew();
            for (int i = 0; i < 1000; i++)
            {
                var part = new ArraySegment<string>(loremIpsumSentences, 0, _random.Next(1, loremIpsumSentences.Length));
                //var part = loremIpsumSentences.Take(_random.Next(1, loremIpsumSentences.Length)); // A bit slower...
                //var part = span.Slice(0, _random.Next(1, span.Length)).ToArray(); // About 6 times slower than ArraySegment<>...
                StringList.Add(string.Join(" ", part));
            }
            t.Stop();
            ElapsedTime = t.Elapsed.ToString();
            //StringList.Add(t.Elapsed.ToString());
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private static string[] loremIpsumSentences =
        {
            "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
            "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
            "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
            "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
        };
    }
}
