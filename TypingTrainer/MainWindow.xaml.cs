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
using System.Windows.Threading;

// Typing Trainer (Draft)

namespace TypingTrainer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        DateTime start;

        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += TimerTickProgress;
            start = DateTime.Now;
        }

        private void TimerTickProgress(object sender, EventArgs e)
        {
            if (progressBar.Value == progressBar.Maximum)
            {
                MessageBox.Show("You haven't completed entering text on time!");
                progressBar.Value = progressBar.Minimum;
            }
            else { progressBar.Value++; }
        }

        private void StartBtnClick(object sender, RoutedEventArgs e)
        {
            timer.Start();
            secondsText.Content = Convert.ToString(DateTime.Now - start);
        }
    }
}
