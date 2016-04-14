using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;
using AddressBook.Annotations;
using AddressBook.Model;
using Template10.Mvvm;
using Template10.Utils;

namespace AddressBook.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private IRepository _mockrepo;
        private PersonViewModel _selectedPerson;

        public ObservableCollection<PersonViewModel> Persons { get; set; }
        //public ObservableCollection<AddressViewModel> Adresses { get; } = new ObservableCollection<AddressViewModel>();

        public PersonViewModel SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                if (Equals(value, _selectedPerson)) return;
                _selectedPerson = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            _mockrepo = new MockRepo();
            Persons = new ObservableCollection<PersonViewModel>(_mockrepo.Get().Select(p=>new PersonViewModel(p)));
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
