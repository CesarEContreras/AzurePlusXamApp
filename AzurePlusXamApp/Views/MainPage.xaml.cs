using System;
using System.Collections.Generic;
using AzurePlusXamApp.ViewModels;
using Xamarin.Forms;

namespace AzurePlusXamApp.Views
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        void Item_Clicked(object sender, System.EventArgs e)
        {
            var _case = MenuListView.SelectedItem as Models.MenuItem; 

            switch(_case.Title)
            {
                case "Login B":
                    {
                        Detail = new NavigationPage(new LoginB());
                        IsPresented = false;
                        break; 
                    }
                case "Where Should We Deliver? - Stack":
                    {
                        Detail = new NavigationPage(new WhereShouldWeDeliverA());
                        IsPresented = false;
                        break;
                    }
                case "Which One Fits Your Life Style? - Stack":
                    {
                        Detail = new NavigationPage(new WhichOneFitsYourLifestyleA());
                        IsPresented = false;
                        break;
                    }
                default:
                    break;

            }
        }
    }
}
