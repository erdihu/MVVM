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
using System.Collections.Specialized;

namespace AddressBook.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private IRepository _mockrepo;
        private PersonViewModel _selectedPerson;

        public ObservableCollection<PersonViewModel> Persons { get; }

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
            Persons = new ObservableCollection<PersonViewModel>(_mockrepo.Get().OrderBy(p => p.FirstName).Select(p => new PersonViewModel(p)));
            Persons.CollectionChanged += Persons_CollectionChanged;

        }

        private void Persons_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
                foreach (PersonViewModel p in e.NewItems)
                    _mockrepo.Insert(p.Model);
            else if (e.Action == NotifyCollectionChangedAction.Remove)
                foreach (PersonViewModel p in e.OldItems)
                    _mockrepo.Delete(p.Model);
        }


        public event PropertyChangedEventHandler PropertyChanged;

        //[NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
