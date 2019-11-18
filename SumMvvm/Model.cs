using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SumMvvm
{
    public class Model : INotifyPropertyChanged
    {
        private int sum, first, second;

        public int First
        {
            get { return first; }
            set
            {
                first = value;
                OnPropertyChanged("First");
            }
        }

        public int Second
        {
            get { return second; }
            set
            {
                second = value;
                OnPropertyChanged("Second");
            }
        }

        public int Sum
        {
            get { return sum; }
            set
            {
                sum = value;
                OnPropertyChanged("Sum");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public Model()
        {
            First = 0;
            Second = 0;
            Sum = 0;
        }
    }
}
