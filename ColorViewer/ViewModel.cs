using PropertyChanged;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Media.Imaging;
using System;
using System.Drawing;

// View Model

namespace ColorViewer
{
    public partial class MainWindow
    {
        [AddINotifyPropertyChangedInterface]
        public class ViewModel
        {
            private ObservableCollection<ColorModel> colors = new();
            public IEnumerable<ColorModel> Colors => colors;

            public ColorModel ColorModel { get; set; } = new();
            public Color SelectedColor { get; set; }

            public ViewModel()
            {
                colors.Add(new ColorModel() { A = 112, B = 20, G = 80, R = 17 });
                colors.Add(new ColorModel() { A = 86, B = 27, G = 172, R = 72 });
                colors.Add(new ColorModel() { A = 50, B = 73, G = 11, R = 2 });
            }

            // todo: not recognizing properties after renaming ColorModel class
            public void AddColor()
            {
                if (colors.Contains(ColorModel.Color))
                {
                    MessageBox.Show("This color already exists!");
                }
                else
                {
                    colors.Add(ColorModel.Color);
                }
            }

            public void RemoveColor()
            {
                colors.Remove(SelectedColor);
            }
        }

    }
}
