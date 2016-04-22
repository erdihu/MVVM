using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using AddressBook.Annotations;
using AddressBook.Model;

namespace AddressBook.ViewModel
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        public Person Model { get; }

        public PersonViewModel(Person p)
        {
            Model = p;
        }

        public Guid Id  => Model.Id; 

        public string FullName => $"{FirstName} {LastName}";

        public string FirstName
        {
            get { return Model.FirstName; }
            set
            {
                if (value == Model.FirstName) return;
                Model.FirstName = value;
                OnPropertyChanged(nameof(FirstName));
                OnPropertyChanged(nameof(LastName));
            }
        }

        public string LastName
        {
            get { return Model.LastName; }
            set
            {
                if (value == Model.LastName) return;
                Model.LastName = value;
                OnPropertyChanged(nameof(LastName));
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public string Email
        {
            get { return Model.Email; }
            set
            {
                if (value == Model.Email) return;
                Model.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string TelephoneMain
        {
            get { return Model.TelephoneMain; }
            set
            {
                if (value == Model.TelephoneMain) return;
                Model.TelephoneMain = value;
                OnPropertyChanged(nameof(TelephoneMain));
            }
        }

        public string TelephoneOther
        {
            get { return Model.TelephoneOther; }
            set
            {
                if (value == Model.TelephoneOther) return;
                Model.TelephoneOther = value;
                OnPropertyChanged(nameof(TelephoneOther));
            }
        }

        public string Skype
        {
            get { return Model.Skype; }
            set
            {
                if (value == Model.Skype) return;
                Model.Skype = value;
                OnPropertyChanged(nameof(Skype));
            }
        }

        public string Website
        {
            get { return Model.Website; }
            set
            {
                if (value == Model.Website) return;
                Model.Website = value;
                OnPropertyChanged(nameof(Website));
            }
        }

        public Address Address
        {
            get { return Model.Address; }
            set
            {
                if (value == Model.Address) return;
                Model.Address = value;
                OnPropertyChanged(nameof(Address));
            }
        }

    }
}
