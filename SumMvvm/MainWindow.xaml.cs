using System.Windows;
using System.Windows.Input;

namespace SumMvvm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();

            viewModel = new ViewModel();
            DataContext = viewModel;
            CommandBindings.Add(
                new CommandBinding(
                    ApplicationCommands.New,
                    delegate (object sender, ExecutedRoutedEventArgs e) { viewModel.Model.Sum = viewModel.Model.First + viewModel.Model.Second; },
                    delegate (object sender, CanExecuteRoutedEventArgs e) { e.CanExecute = true; })
                    );
        }
    }
}
