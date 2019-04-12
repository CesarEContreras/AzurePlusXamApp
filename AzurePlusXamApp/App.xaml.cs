using System;
using AzurePlusXamApp.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Push;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AzurePlusXamApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginA());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("50ffe9df-b14c-4083-a969-c321fd85d9cc", typeof(Push));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
