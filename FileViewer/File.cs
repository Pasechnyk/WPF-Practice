using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Model (File Class)

namespace FileViewer
{
    [AddINotifyPropertyChangedInterface]
    public class File
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public DateTime LastChanged { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
