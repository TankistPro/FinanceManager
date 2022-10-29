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

namespace FinanceManager
{
    /// <summary>
    /// Логика взаимодействия для AddOperationWindow.xaml
    /// </summary>
    public partial class AddOperationWindow : Window
    {
        public string ViewModel { get; set; }

        public AddOperationWindow()
        {
            InitializeComponent();
        }
    }
}
