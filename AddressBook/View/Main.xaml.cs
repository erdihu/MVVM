using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using AddressBook.ViewModel;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AddressBook.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Main : Page
    {
        private MainViewModel _model;
        public Main()
        {
            this.InitializeComponent();

        }

        //private void DeleteButton_OnClick(object sender, RoutedEventArgs e)
        //{
        //    if(_model.SelectedPerson != null)
        //        _model.Persons.Remove(_model.SelectedPerson);
        //}

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            _model = (MainViewModel)e.Parameter;
        }

        //private async void SaveButton_OnClick(object sender, RoutedEventArgs e)
        //{
        //    //Actually, this is just a placebo. Does nothing but to take focus off the textbox. Focusing off automatically saves the model.
        //    if (_model.SelectedPerson != null)
        //    {
        //        MessageDialog md = new MessageDialog("Saved");
        //        await md.ShowAsync();
        //    }
        //}
    }
}
