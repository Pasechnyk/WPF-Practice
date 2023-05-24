using Microsoft.Win32;
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

// Task - Create File Viewer App using MVVM model.

namespace FileViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel model = new();
        public string? Path { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = model;
        }

        private void OpenClicked(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == true)
            {
                Path = dialog.FileName;
                pathTxt.Text = Path;
            }
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            model.NextFile();
        }

        private void previousBtn_Click(object sender, RoutedEventArgs e)
        {
            model.PreviousFile();
        }
    }
}
