using Microsoft.Win32;
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

// Task - Color Picker appplication with themes.

namespace ColorViewer
{
    public partial class MainWindow : Window
    {
        private ViewModel viewModel = new();

        public MainWindow()
        {
            InitializeComponent();

            DetectTheme();

            this.DataContext = viewModel;
        }

        // Toggle dark/light theme
        private void ToggleButtonChecked(object sender, RoutedEventArgs e)
        {
            if ((sender as ToggleButton).IsChecked ?? false)
            {
                Resources["gridBackGround"] = new SolidColorBrush(Color.FromArgb(250, 61, 46, 87));
                Resources["headerBackGround"] = new SolidColorBrush(Colors.Black);
                Resources["slidersBackGround"] = new SolidColorBrush(Colors.Violet);
                Resources["buttonMarkerBackGround"] = new SolidColorBrush(Color.FromArgb(250, 103, 58, 183));
                Resources["panelBackGround"] = new SolidColorBrush(Color.FromArgb(250, 103, 58, 183));
                Resources["labelForeGround"] = new SolidColorBrush(Colors.White);
                Resources["listBackGround"] = new SolidColorBrush(Color.FromArgb(250, 151, 106, 218));
                Resources["listForeGround"] = new SolidColorBrush(Colors.White);
                Resources["borderBackGround"] = new SolidColorBrush(Colors.Violet);
            }
            else
            {
                Resources["gridBackGround"] = new SolidColorBrush(Colors.White);
                Resources["headerBackGround"] = new SolidColorBrush(Colors.White);
                Resources["slidersBackGround"] = new SolidColorBrush(Color.FromArgb(250, 103, 58, 183));
                Resources["buttonMarkerBackGround"] = new SolidColorBrush(Color.FromArgb(250, 185, 169, 190));
                Resources["panelBackGround"] = new SolidColorBrush(Color.FromArgb(250, 220, 216, 223));
                Resources["labelForeGround"] = new SolidColorBrush(Colors.Black);
                Resources["listBackGround"] = new SolidColorBrush(Color.FromArgb(250, 231, 217, 255));
                Resources["listForeGround"] = new SolidColorBrush(Colors.Black);
                Resources["borderBackGround"] = new SolidColorBrush(Color.FromArgb(250, 159, 108, 221));
            }
        }

        // Change the theme according to Windows one
        private void DetectTheme()
        {
            int res = (int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", null);
            if (res == 0)
            {
                Resources["gridBackGround"] = new SolidColorBrush(Color.FromArgb(250, 61, 46, 87));
                Resources["headerBackGround"] = new SolidColorBrush(Colors.Black);
                Resources["slidersBackGround"] = new SolidColorBrush(Colors.Violet);
                Resources["buttonMarkerBackGround"] = new SolidColorBrush(Color.FromArgb(250, 103, 58, 183));
                Resources["panelBackGround"] = new SolidColorBrush(Color.FromArgb(250, 103, 58, 183));
                Resources["labelForeGround"] = new SolidColorBrush(Colors.White);
                Resources["listBackGround"] = new SolidColorBrush(Color.FromArgb(250, 151, 106, 218));
                Resources["listForeGround"] = new SolidColorBrush(Colors.White);
                Resources["borderBackGround"] = new SolidColorBrush(Colors.Violet);
            }
            else
            {
                Resources["gridBackGround"] = new SolidColorBrush(Colors.White);
                Resources["headerBackGround"] = new SolidColorBrush(Colors.White);
                Resources["slidersBackGround"] = new SolidColorBrush(Color.FromArgb(250, 103, 58, 183));
                Resources["buttonMarkerBackGround"] = new SolidColorBrush(Color.FromArgb(250, 185, 169, 190));
                Resources["panelBackGround"] = new SolidColorBrush(Color.FromArgb(250, 220, 216, 223));
                Resources["labelForeGround"] = new SolidColorBrush(Colors.Black);
                Resources["listBackGround"] = new SolidColorBrush(Color.FromArgb(250, 231, 217, 255));
                Resources["listForeGround"] = new SolidColorBrush(Colors.Black);
                Resources["borderBackGround"] = new SolidColorBrush(Color.FromArgb(250, 159, 108, 221));
            }               
        }

        private void CreateBtnClick(object sender, RoutedEventArgs e)
        {
            viewModel.AddColor();
        }

        private void RemoveBtnClick(object sender, RoutedEventArgs e)
        {
            viewModel.RemoveColor();
        }

        private void SaveBtnClick(object sender, RoutedEventArgs e)
        {
            viewModel.SavePalette();
        }

    }
}
