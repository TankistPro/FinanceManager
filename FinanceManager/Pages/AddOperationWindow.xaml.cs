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

namespace FinanceManager
{
    /// <summary>
    /// Логика взаимодействия для AddOperationWindow.xaml
    /// </summary>
    public partial class AddOperationWindow : Window
    {
        private readonly BaseRepository<OperationHistory> _historyRepository;
        public string ViewModel { get; set; }

        public AddOperationWindow()
        {
            InitializeComponent();
            _historyRepository = new BaseRepository<OperationHistory>();
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
                this.Close();
            }

            Console.WriteLine(response);
        }
    }
}
