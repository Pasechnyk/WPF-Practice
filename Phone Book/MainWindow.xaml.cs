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

// Task - Create Phone Book App using collection binding.

namespace PhoneBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel model = new();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = model;
        }

        private void AddContactBtnClick(object sender, RoutedEventArgs e)
        {
            model.Add();
        }

        private void RemoveContactBtnClick(object sender, RoutedEventArgs e)
        {
            model.Remove();
        }
    }
}
