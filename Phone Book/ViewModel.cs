using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ViewModel Class

namespace PhoneBook
{
    public class ViewModel
    {
        private ObservableCollection<Contact> contacts = new();
        public IEnumerable<Contact> Contacts => contacts;
        public Contact SelectedContact { get; set; }

        public ViewModel()
        {
            contacts.Add(new Contact() { Name = "Jane", Surname = "Sandres", Phone = "+7007575828", Country = "Italy"});
            contacts.Add(new Contact() { Name = "Sam", Surname = "Sandres", Phone = "+608955520", Country = "Poland" });
            contacts.Add(new Contact() { Name = "Andrew", Surname = "Oliynyk", Phone = "+388355863", Country = "Ukraine" });
        }

        public void Add()
        {
            if (SelectedContact != null)
            {
                this.contacts.Add(SelectedContact);
            }
        }

        public void Remove()
        {
            if (SelectedContact != null)
            {
                this.contacts.Remove(SelectedContact);
            }
        }
    }
}
