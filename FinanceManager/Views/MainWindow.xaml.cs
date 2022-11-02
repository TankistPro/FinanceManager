using System.Windows;
using FinanceManager.Models;

namespace FinanceManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mainViewModel;
        public MainWindow()
        {
            InitializeComponent();

            mainViewModel = new MainViewModel();
            DataContext = mainViewModel;
        }

        private void AddOperation(object sender, RoutedEventArgs e)
        {
            AddOperationWindow addOperationWindow = new AddOperationWindow(mainViewModel);
            addOperationWindow.Show();
        }
    }
}
