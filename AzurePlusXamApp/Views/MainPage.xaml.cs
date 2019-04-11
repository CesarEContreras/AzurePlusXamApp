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

        void OnTapGestureRecognizerTapped(object sender, TappedEventArgs args)
        {
            var _case = args.Parameter as string;

            switch(_case)
            {
                case "Page1":
                    {
                        Detail = new NavigationPage(new WhereShouldWeDeliverA());
                        IsPresented = false;
                        break; 
                    }
                case "Page2":
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
