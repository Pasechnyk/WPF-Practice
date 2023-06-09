using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    public partial class MainWindow : Window
    {
        public int First { get; set; }
        public int Second { get; set; }
        public char Operation { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            SystemThemeCheck();
        }

        // Toggle themes
        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            if ((sender as ToggleButton).IsChecked ?? false)
            {
                Resources["gridBackGround"] = new SolidColorBrush(Color.FromArgb(250, 61, 46, 87));
                Resources["buttonMarkerBackGround"] = new SolidColorBrush(Colors.Black);
                Resources["buttonMarkerForeGround"] = new SolidColorBrush(Colors.BlueViolet);
                Resources["borderBackGround"] = new SolidColorBrush(Colors.MediumPurple);
            }
            else
            {
                Resources["gridBackGround"] = new SolidColorBrush(Colors.White);
                Resources["buttonMarkerBackGround"] = new SolidColorBrush(Color.FromArgb(250, 183, 217, 208));
                Resources["buttonMarkerForeGround"] = new SolidColorBrush(Colors.Black);
                Resources["borderBackGround"] = new SolidColorBrush(Color.FromArgb(250, 209, 228, 224));
            }
        }

        // Adapt to system theme from registry
        private void SystemThemeCheck()
        {
            int res = (int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", null);
            if (res == 0)
            {
                Resources["gridBackGround"] = new SolidColorBrush(Colors.Gray);
                Resources["buttonMarkerBackGround"] = new SolidColorBrush(Colors.Black);
                Resources["buttonMarkerForekGround"] = new SolidColorBrush(Colors.White);
                Resources["borderBackGround"] = new SolidColorBrush(Colors.White);
            }
            else
            {
                Resources["gridBackGround"] = new SolidColorBrush(Colors.White);
                Resources["buttonMarkerBackGround"] = new SolidColorBrush(Color.FromArgb(250, 183, 217, 208));
                Resources["buttonMarkerForekGround"] = new SolidColorBrush(Colors.Black);
                Resources["borderBackGround"] = new SolidColorBrush(Color.FromArgb(250, 209, 228, 224));
            }
        }

        // Clean surface
        private void CleanClick(object sender, RoutedEventArgs e)
        {
            First = 0;
            Second = 0;
            txtBox.Text = "";
        }

        // Click
        private void NumberClick(object sender, RoutedEventArgs e)
        {
            // fixed output
            if (txtBox.Text == "+" || txtBox.Text == "-" 
                || txtBox.Text == "/" || txtBox.Text == "*")
            {
                txtBox.Text = "";
            }

            Button button = sender as Button;

            txtBox.Text += button.Content.ToString();
            historyBox.Text += button.Content.ToString();

            Second = Convert.ToInt32(txtBox.Text);
        }

        // Operations:
        // Plus
        private void PlusClick(object sender, RoutedEventArgs e)
        {
            First = Convert.ToInt32(txtBox.Text);

            Operation = '+';

            txtBox.Text = Operation.ToString();
            historyBox.Text += Operation.ToString();
        }

        // Minus
        private void MinusClick(object sender, RoutedEventArgs e)
        {
            First = Convert.ToInt32(txtBox.Text);

            Operation = '-';

            txtBox.Text = Operation.ToString();
            historyBox.Text += Operation.ToString();
        }

        // Divide
        private void DivClick(object sender, RoutedEventArgs e)
        {
            First = Convert.ToInt32(txtBox.Text);

            Operation = '/';

            txtBox.Text = Operation.ToString();
            historyBox.Text += Operation.ToString();
        }

        // Multiply
        private void MultClick(object sender, RoutedEventArgs e)
        {
            First = Convert.ToInt32(txtBox.Text);

            Operation = '*';

            txtBox.Text = Operation.ToString();
            historyBox.Text += Operation.ToString();
        }


        // Equals
        private void EqualsClick(object sender, RoutedEventArgs e)
        {
            Second = Convert.ToInt32(txtBox.Text);

            switch (Operation)
            {
                case '+':
                    txtBox.Text = (First + Second).ToString();
                    break;
                case '-':
                    if (First > Second)
                    {
                        txtBox.Text = (First - Second).ToString();
                    }
                    else
                    {
                        MessageBox.Show("First number is lesser, can't complete!");
                    }
                    break;
                case '*':
                    txtBox.Text = (First * Second).ToString();
                    break;
                case '/':
                    if (First > Second)
                    {
                        txtBox.Text = (First / Second).ToString();
                    }
                    else
                    {
                        MessageBox.Show("First number is lesser, can't complete!");
                    }
                    break;
                default:
                    break;
            }

        }

    }
}
