using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzurePlusXamApp.ViewModels;
using Xamarin.Forms;

namespace AzurePlusXamApp.Views
{
    public partial class LoginA : ContentPage
    {
        public LoginA()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
