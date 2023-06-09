using PropertyChanged;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

// Model of Color class

namespace ColorViewer
{
    public partial class MainWindow
    {
        [AddINotifyPropertyChangedInterface]
        public class ColorModel : INotifyPropertyChanged
        {
            public byte a;
            public byte r;
            public byte g;
            public byte b;
            public byte A
            {   get => a;
                set
                {
                    a = value;
                    OnPropertyChanged(nameof(A));
                    OnPropertyChanged(nameof(Color));
                }
            }
            public byte R
            {
                get => r;
                set
                {
                    r = value;
                    OnPropertyChanged(nameof(R));
                    OnPropertyChanged(nameof(Color));
                }
            }
            public byte G
            {
                get => g;
                set
                {
                    g = value;
                    OnPropertyChanged(nameof(G));
                    OnPropertyChanged(nameof(Color));
                }
            }
            public byte B
            {
                get => b;
                set
                {
                    b = value;
                    OnPropertyChanged(nameof(B));
                    OnPropertyChanged(nameof(Color));
                }
            }

            public Color Color => Color.FromArgb(A, R, G, B);

            public event PropertyChangedEventHandler PropertyChanged;
            protected void OnPropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

            // convert to hex-format
            public override string ToString()
            {
                string color = string.Format("#{0:X2}{1:X2}{2:X2}", R, G, B);
                return $"{color}";
            }
        }
    }
}
