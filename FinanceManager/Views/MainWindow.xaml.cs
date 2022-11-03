using System.Windows;
using AutoMapper;
using FinanceManager.Infrastructure.Interfaces;
using FinanceManager.Models;

namespace FinanceManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IOperationHistoryRepository _operationHistoryRepository;
        private readonly IUserRepository _userRepository;

        MainViewModel mainViewModel;
        public MainWindow(IMapper mapper, IUserRepository userRepository,
            IOperationHistoryRepository operationHistoryRepository)
        {
            InitializeComponent();

            _operationHistoryRepository = operationHistoryRepository;
            _userRepository = userRepository;

            mainViewModel = new MainViewModel(mapper);
            DataContext = mainViewModel;
        }

        private void AddOperation(object sender, RoutedEventArgs e)
        {
            AddOperationWindow addOperationWindow = new AddOperationWindow(mainViewModel, _userRepository, _operationHistoryRepository);
            addOperationWindow.Show();
        }
    }
}
