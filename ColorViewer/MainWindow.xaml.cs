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

// Task - Create Color Viewer application using bindings.

namespace ColorViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel viewModel = new();

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = viewModel;
        }
        private void CreateBtnClick(object sender, RoutedEventArgs e)
        {
            viewModel.AddColor();
        }

        private void RemoveBtnClick(object sender, RoutedEventArgs e)
        {
            viewModel.RemoveColor();
        }
    }
}
