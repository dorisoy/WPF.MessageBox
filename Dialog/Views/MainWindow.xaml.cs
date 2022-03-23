﻿using MessageBoxUtilities;
using System;
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

namespace Dialog.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private IMessageBoxService _messageBox;

        public MainWindow()
        {
            InitializeComponent();
            _messageBox = new MessageBoxService();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _messageBox.Show("Just a Message");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _messageBox.Show("A Message should appear here", "Caption of the dialog", MessageBoxServiceButton.OkCancel, MessageBoxServiceIcon.Warning);
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            _messageBox.Show("A Message should appear here", "Caption of the dialog", MessageBoxServiceButton.YesNo, MessageBoxServiceIcon.Information,MessageBoxServiceResult.Yes);
        }
    }
}