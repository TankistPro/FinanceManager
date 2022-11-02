using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using FinanceManager.Infrastructure.Repositories;
using FinanceManager.Domain;
using FinanceManager.Models;

namespace FinanceManager
{
    /// <summary>
    /// Логика взаимодействия для AddOperationWindow.xaml
    /// </summary>
    public partial class AddOperationWindow : Window
    {
        private readonly BaseRepository<OperationHistory> _historyRepository;
        private MainViewModel _mainViewModel;
        public AddOperationWindow(MainViewModel mainViewModel)
        {
            InitializeComponent();

            _historyRepository = new BaseRepository<OperationHistory>();
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

            bool response = await _historyRepository.AddAsync(history);

            if (response)
            {
                var total = Convert.ToInt32(_mainViewModel.Balance) + value;
                _mainViewModel.Balance = total.ToString();

                this.Close();
            }

            Console.WriteLine(response);
        }
    }
}
