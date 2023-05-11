using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// Contacts Class with INotifyPropertyChanged interface

namespace PhoneBook
{
    public class Contact : INotifyPropertyChanged
    {
        public string name;
        public string surname;

        public string Name
        {
            get => name;
            set
            {
                this.name = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FullInfo));
            }
        }

        public string Surname
        {
            get => surname;
            set
            {
                this.name = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FullInfo));
            }
        }

        public string Phone { get; set; }
        public string Country { get; set; }

        public string FullInfo => Name + " " + Surname;

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return $"{FullInfo} : {Phone} - {Country}";
        }

        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
