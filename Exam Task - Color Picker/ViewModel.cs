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

            private ColorModel colorModel = new();

            public ColorModel ColorModel
            {
                get { return colorModel; }
                set { colorModel = value ?? new(); }
            }

            public ViewModel()
            {
                colors.Add(new ColorModel() { A = 112, B = 20, G = 80, R = 17 });
                colors.Add(new ColorModel() { A = 86, B = 27, G = 172, R = 72 });
                colors.Add(new ColorModel() { A = 50, B = 73, G = 11, R = 2 });
                colors.Add(new ColorModel() { A = 120, B = 41, G = 70, R = 14 });
                colors.Add(new ColorModel() { A = 38, B = 18, G = 39, R = 59 });
            }

            public void AddColor()
            {
                if (colors.Select(x => x.Color).Contains(ColorModel.Color))
                {
                    MessageBox.Show("This color already exists!");
                }
                else
                {
                    colors.Add(ColorModel);
                }
            }

            public void RemoveColor()
            {
                colors.Remove(ColorModel);
            }
        }

    }
}
