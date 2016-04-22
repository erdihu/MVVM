using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Annotations;
using AddressBook.Model;

namespace AddressBook.ViewModel
{
    public class AddressViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //[NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Address _address;

        public Guid Id => _address.Id;

        public AddressViewModel(Address a)
        {
            _address = a;
        }

        public string Street
        {
            get { return _address.Street; }
            set
            {
                if (value == _address.Street) return;
                _address.Street = value;
                OnPropertyChanged(nameof(Street));
            }
        }

        public string City
        {
            get { return _address.City; }
            set
            {
                if (value == _address.City) return;
                _address.City = value;
                OnPropertyChanged(nameof(City));
            }
        }

        public string PostalCode
        {
            get { return _address.PostalCode; }
            set
            {
                if (value == _address.PostalCode) return;
                _address.PostalCode = value;
                OnPropertyChanged(nameof(PostalCode));
            }
        }

        public string Country
        {
            get { return _address.Country; }
            set
            {
                if (value == _address.Country) return;
                _address.Country = value;
                OnPropertyChanged(nameof(Country));
            }
        }


    }
}
