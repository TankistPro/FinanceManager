using System.Windows;
using AutoMapper;
using FinanceManager.Models;

namespace FinanceManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mainViewModel;
        public MainWindow(IMapper mapper)
        {
            InitializeComponent();

            mainViewModel = new MainViewModel(mapper);
            DataContext = mainViewModel;
        }

        private void AddOperation(object sender, RoutedEventArgs e)
        {
            AddOperationWindow addOperationWindow = new AddOperationWindow(mainViewModel);
            addOperationWindow.Show();
        }
    }
}
