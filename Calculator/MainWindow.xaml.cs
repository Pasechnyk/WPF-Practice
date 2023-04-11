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

// Task - Create Calculator App

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int First { get; set; }
        public int Second { get; set; }
        public float Result { get; set; }
        public char Operation { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        // Clean surface
        private void CleanClick(object sender, RoutedEventArgs e)
        {
            First = 0;
            Second = 0;
            txtBox.Text = "0";
        }

        // Choose button
        private void NumberClick(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            txtBox.Text += button.Content.ToString();
            Second = Int32.Parse(txtBox.Text);
        }

        // Operations:
        // Plus
        private void PlusClick(object sender, RoutedEventArgs e)
        {
            First = Int32.Parse(txtBox.Text);
            Operation = '+';
            txtBox.Text = Operation.ToString();
        }

        // Minus
        private void MinusClick(object sender, RoutedEventArgs e)
        {
            First = Int32.Parse(txtBox.Text);

            Operation = '-';
            txtBox.Text = Operation.ToString();
        }

        // Divide
        private void DivClick(object sender, RoutedEventArgs e)
        {
            First = Int32.Parse(txtBox.Text);
            Operation = '/';

            txtBox.Text = Operation.ToString();
        }

        // Multiply
        private void MultClick(object sender, RoutedEventArgs e)
        {
            First = Int32.Parse(txtBox.Text);
            Operation = '*';

            txtBox.Text = Operation.ToString();
        }

        // Equals
        private void EqualsClick(object sender, RoutedEventArgs e)
        {
            Second = Int32.Parse(txtBox.Text);

            switch (Operation)
            {
                case '+':
                    Result = First + Second;
                    break;
                case '-':
                    Result = First - Second;
                    break;
                case '*':
                    Result = First * Second;
                    break;
                case '/':
                    Result = First / Second;
                    break;
                default:
                    break;
            }
            txtBox.Text = Result.ToString();
        }
    }
}
