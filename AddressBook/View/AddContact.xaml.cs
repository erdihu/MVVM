using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using AddressBook.Model;
using AddressBook.ViewModel;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AddressBook.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddContact : Page
    {
        private MockRepo _repo = new MockRepo();
        public AddContact()
        {
            this.InitializeComponent();
            this.Loaded += OnLoad;
            SystemNavigationManager.GetForCurrentView().BackRequested += OnBackRequested;
        }

        private void OnBackRequested(object sender, BackRequestedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
                e.Handled = true;
            }
        }

        private void OnLoad(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            }

        }

        private void SaveButton_OnClick(object sender, RoutedEventArgs e)
        {
            
            Person p = new Person()
            {
                Id = Guid.NewGuid(),
                FirstName = TxtFName.Text,
                LastName = TxtLName.Text,
                Email = TxtEmail.Text,
                TelephoneMain = TxtT1.Text,
                TelephoneOther = TxtT2.Text,
                Skype = TxtSkype.Text,
                Website = TxtWebsite.Text,
                Address = new Address
                {
                    Id = Guid.NewGuid(),
                    Street = TxtStreet.Text,
                    City = TxtCity.Text,
                    PostalCode = TxtPostalcode.Text,
                    Country = TxtCountry.Text
                }
            };

            _repo.Insert(p);
        }
    }
}
