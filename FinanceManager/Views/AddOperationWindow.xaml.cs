using System;
using System.Windows;
using FinanceManager.Domain;
using FinanceManager.Models;
using FinanceManager.Infrastructure.Interfaces;

namespace FinanceManager
{
    /// <summary>
    /// Логика взаимодействия для AddOperationWindow.xaml
    /// </summary>
    public partial class AddOperationWindow : Window
    {
        private readonly IOperationHistoryRepository _operationHistoryRepository;
        private readonly IUserRepository _userRepository;

        private MainViewModel _mainViewModel;

        public AddOperationWindow(MainViewModel mainViewModel, 
            IUserRepository userRepository, 
            IOperationHistoryRepository operationHistoryRepository)
        {
            InitializeComponent();

            _operationHistoryRepository = operationHistoryRepository;
            _userRepository = userRepository;

            _mainViewModel = mainViewModel;
        }

        async public void CreateOperation(object sender, RoutedEventArgs e)
        {
            int value = Convert.ToInt32(operationValue.Text);
            string comment = operationComment.Text;

            OperationHistory history = new OperationHistory()
            {
                Value = value,
                Comment = comment,
                DateCreated = DateTime.Now,
                UserId = 1
            };

            bool userReposnse = await this._userRepository.UpdateBalance(history.Value, history.UserId);
            bool historyResponse = await this._operationHistoryRepository.CreateOperationHistory(history);

            if (userReposnse && historyResponse)
            {
                var total = Convert.ToInt32(_mainViewModel.Balance) + history.Value;
                _mainViewModel.Balance = total.ToString();

                this.Close();
            }
        }
    }
}
