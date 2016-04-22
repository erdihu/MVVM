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
using AddressBook.ViewModel;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AddressBook.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Shell : Page
    {
        private readonly MainViewModel _model = new MainViewModel();
        public Shell()
        {
            this.InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            this.DataContext = _model;
            this.Loaded += Shell_Loaded;
#if DEBUG
            this.SizeChanged += Shell_SizeChanged;
#endif
            SplitViewFrame.Navigate(typeof(Main), _model);

        }

        private void Shell_Loaded(object sender, RoutedEventArgs e)
        {
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }

        private void HamburgerButton_OnClick(object sender, RoutedEventArgs e)
        {
            SplitView.IsPaneOpen = !SplitView.IsPaneOpen;
        }

#if DEBUG
        private void Shell_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            WidthIndicator.Text = "<- " + e.NewSize.Width.ToString() + " ->";
        }
#endif

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AddContact), _model);
        }

        private void SeeAll_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SeeAll), _model);
        }
    }
}
