﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ClienteViewModel _viewModel = new ClienteViewModel();

        public MainWindow()
        {
            InitializeComponent();
            base.DataContext = this._viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // code-behind... (command?)
            this._viewModel.Nome = "Guinther";
        }
    }
}
