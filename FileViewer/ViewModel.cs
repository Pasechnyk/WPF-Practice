using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// View Model of File Viewer

namespace FileViewer
{
    [AddINotifyPropertyChangedInterface]
    public class ViewModel
    {
        private ObservableCollection<File> files = new();
        public IEnumerable<File> Files => files;
        public File SelectedFile { get; set; }
        public bool CanNext => files.IndexOf(SelectedFile) < (files.Count() - 1);

        public ViewModel()
        {
            files.Add(new File()
            {
                Name = "picture.png",
                Size = "251",
                LastChanged = new DateTime(2023, 02, 12)
            });
            files.Add(new File()
            {
                Name = "notes.txt",
                Size = "13",
                LastChanged = new DateTime(2023, 01, 08)
            });
            files.Add(new File()
            {
                Name = "text.doc",
                Size = "68",
                LastChanged = new DateTime(2023, 04, 25)
            });
            files.Add(new File()
            {
                Name = "cat.jpg",
                Size = "140",
                LastChanged = new DateTime(2023, 05, 01)
            });
        }

        public void NextFile()
        {
            if (files.IndexOf(SelectedFile) - 1 >= 0)
            {
                SelectedFile = files[files.IndexOf(SelectedFile) - 1];
            }
        }

        public void PreviousFile()
        {
            if (files.IndexOf(SelectedFile) + 1 <= files.Count - 1)
            {
                SelectedFile = files[files.IndexOf(SelectedFile) + 1];
            }
        }
    }
}
