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

// Typing Trainer 

namespace TypingTrainer
{
    public partial class MainWindow : Window
    {
        public DispatcherTimer timer = new DispatcherTimer();
        public DateTime start;
        public int Mistakes { get; set; } = 0;

        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += TimerTickProgress;
            start = DateTime.Now;
        }

        // Timer
        private void TimerTickProgress(object sender, EventArgs e)
        {
            if (progressBar.Value == progressBar.Maximum)
            {
                MessageBox.Show("You haven't completed entering text on time!");
                progressBar.Value = progressBar.Minimum;
            }
            else { progressBar.Value++; }    
        }

        // Start with levels of difficulty (1-4, 5-8, 9-10)
        private void StartBtnClick(object sender, RoutedEventArgs e)
        {
            timer.Start();
            secondsText.Content = Convert.ToString(DateTime.Now - start);

            switch (sliderBar.Value)
            {
                case >= 1 and <= 4:
                    preparedText.Text = "So insisted received is occasion advanced honoured.";
                    break;
                case >= 5 and <= 8:
                    preparedText.Text = "Thrown any behind afford either the set depend one temper. \nInstrument melancholy in acceptance collecting frequently be if." +
                            "\nZealously now pronounce existence add you instantly say offending. Merry their far had widen was. Concerns no in expenses.";
                    break;
                case >= 9:
                    preparedText.Text = "Maids table how learn drift but purse stand yet set. Music me house could among oh as their." +
                            "\nPiqued our sister shy nature almost his wicket. Hand dear so we hour to. He we be hastily offence effects he service." +
                            "\nSympathize it projection ye insipidity celebrated my pianoforte indulgence. Point his truth put style." +
                            "\nElegance exercise as laughing proposal mistaken if.We up precaution an it solicitude acceptance invitation.";
                    break;
                default:
                    break;
            }
        }

        // Full reset of progress
        private void ResetBtnClick(object sender, RoutedEventArgs e)
        {
            preparedText.Text = "";
            inputText.Text = "";
            timer.Stop();
            progressBar.Value = 0;
            Mistakes = 0;
            mistakesText.Content = Mistakes.ToString();
        }

        // Input text changed
        private void InputTextChanged(object sender, TextChangedEventArgs e)
        {
            string givenText = preparedText.Text;
            string writtenText = inputText.Text;

            if (writtenText.Length == givenText.Length - 1)
            {
                timer.Stop();

                MessageBox.Show($"Succesfully finished!" +
                    $"\nYour time: {DateTime.Now.Second - start.Second}seconds." +
                    $"\nMistakes made: {Mistakes}\n");
            }

            for (int i = 0; i < writtenText.Length; i++)
            {
                if (writtenText[i] != givenText[i])
                {
                    inputText.Text = inputText.Text.Substring(0, inputText.Text.Length - 1);
                    inputText.Select(inputText.Text.Length, 0);

                    Mistakes++;
                    mistakesText.Content = Mistakes.ToString();
                }
            }
        }
    }
}
