﻿using System;
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

namespace FinanceManager.Views
{
    /// <summary>
    /// Логика взаимодействия для OperationHistoryWindow.xaml
    /// </summary>
    public partial class OperationHistoryWindow : Window
    {
        public OperationHistoryWindow()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
