using PropertyChanged;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Media.Imaging;
using System;
using System.Drawing;
using Microsoft.Win32;
using System.IO;

// View Model of Color collection

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

            // Save palette
            public void SavePalette()
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = ".txt";

                if (saveFile.ShowDialog() == true)
                {
                    File.WriteAllLines(saveFile.FileName, colors.Select(x => $"A={x.A}, R={x.R}, G={x.G}, B={x.B}."));
                    MessageBox.Show("Successfully saved!");
                }
            }

            // Add new color to list
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
            
            // Remove color from list
            public void RemoveColor()
            {
                colors.Remove(ColorModel);
            }
        }

    }
}
