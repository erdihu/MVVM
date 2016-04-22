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

        //[NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Person _person;

        public PersonViewModel(Person p)
        {
            _person = p;
        }

        public Guid Id  => _person.Id; 

        public string FullName => $"{FirstName} {LastName}";

        public string FirstName
        {
            get { return _person.FirstName; }
            set
            {
                if (value == _person.FirstName) return;
                _person.FirstName = value;
                OnPropertyChanged(nameof(FirstName));
                OnPropertyChanged(nameof(LastName));
            }
        }

        public string LastName
        {
            get { return _person.LastName; }
            set
            {
                if (value == _person.LastName) return;
                _person.LastName = value;
                OnPropertyChanged(nameof(LastName));
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public string Email
        {
            get { return _person.Email; }
            set
            {
                if (value == _person.Email) return;
                _person.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string TelephoneMain
        {
            get { return _person.TelephoneMain; }
            set
            {
                if (value == _person.TelephoneMain) return;
                _person.TelephoneMain = value;
                OnPropertyChanged(nameof(TelephoneMain));
            }
        }

        public string TelephoneOther
        {
            get { return _person.TelephoneOther; }
            set
            {
                if (value == _person.TelephoneOther) return;
                _person.TelephoneOther = value;
                OnPropertyChanged(nameof(TelephoneOther));
            }
        }

        public string Skype
        {
            get { return _person.Skype; }
            set
            {
                if (value == _person.Skype) return;
                _person.Skype = value;
                OnPropertyChanged(nameof(Skype));
            }
        }

        public string Website
        {
            get { return _person.Website; }
            set
            {
                if (value == _person.Website) return;
                _person.Website = value;
                OnPropertyChanged(nameof(Website));
            }
        }

        public Address Address
        {
            get { return _person.Address; }
            set
            {
                if (value == _person.Address) return;
                _person.Address = value;
                OnPropertyChanged(nameof(Address));
            }
        }

    }
}
