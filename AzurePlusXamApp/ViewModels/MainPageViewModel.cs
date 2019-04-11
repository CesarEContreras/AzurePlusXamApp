using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace AzurePlusXamApp.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ObservableCollection<Models.MenuItem> MenuItems { get; set; }
        public ICommand TapCommand { get; set; }

        public MainPageViewModel()
        {
            MenuItems = new ObservableCollection<Models.MenuItem>()
            {
                new Models.MenuItem("Login A"),
                new Models.MenuItem("Login B"),
                new Models.MenuItem("Where Should We Deliver? - Stack"),
                new Models.MenuItem("Which One Fits Your Life Style? - Stack"),
            };
        }

        void NavigateToPage(Models.MenuItem page)
        {
             
        }
    }
}
