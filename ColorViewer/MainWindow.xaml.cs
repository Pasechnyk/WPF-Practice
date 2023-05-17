using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public class ViewModel
        {
            private ObservableCollection<Color> colors = new();
            public IEnumerable<Color> Colors => colors;
            public Color SelectedColor { get; set; } = new();

            public ViewModel()
            {
                colors.Add(new Color() { A = 112, B = 20, G = 80, R = 17 });
                colors.Add(new Color() { A = 86, B = 27, G = 172, R = 72 });
                colors.Add(new Color() { A = 50, B = 73, G = 11, R = 2 });
            }

            public void AddColor()
            {
                
            }
            public void RemoveColor()
            {

            }
        }

        public class Color : ICloneable
        {
            public int A { get; set; }
            public int R { get; set; }
            public int G { get; set; }
            public int B { get; set; }

            public object Clone()
            {
                var copy = (Color)this.MemberwiseClone();

                copy.A = this.A;
                copy.R = this.R;
                copy.G = this.G;
                copy.B = this.B;

                return copy;
            }

            public override string ToString()
            {
                return $"{R}{G}{B} - Opacity {A}";
            }
        }

    }
}
