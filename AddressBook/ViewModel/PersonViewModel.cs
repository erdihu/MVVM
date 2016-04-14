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

        private Person _person;

        public PersonViewModel(Person p)
        {
            _person = p;
        }

        public Guid Id { get { return _person.Id; } }

        public string FirstName
        {
            get { return _person.FirstName; }
            set
            {
                _person.FirstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public string LastName
        {
            get { return _person.LastName; }
            set
            {
                _person.LastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        public string Email
        {
            get { return _person.Email; }
            set
            {
                _person.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string TelephoneMain
        {
            get { return _person.TelephoneMain; }
            set
            {
                _person.TelephoneMain = value;
                OnPropertyChanged(nameof(TelephoneMain));
            }
        }

        public string TelephoneOther
        {
            get { return _person.TelephoneOther; }
            set
            {
                _person.TelephoneOther = value;
                OnPropertyChanged(nameof(TelephoneOther));
            }
        }

        public string Skype
        {
            get { return _person.Skype; }
            set
            {
                _person.Skype = value;
                OnPropertyChanged(nameof(Skype));
            }
        }

        public string Website
        {
            get { return _person.Website; }
            set
            {
                _person.Website = value;
                OnPropertyChanged(nameof(Website));
            }
        }

        public Address Address
        {
            get { return _person.Address; }
            set
            {
                _person.Address = value;
                OnPropertyChanged(nameof(Address));
            }
        }

    }
}
