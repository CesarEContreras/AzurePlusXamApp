using System;
using AzurePlusXamApp.Views;
using AzurePlusXamApp.Views.WhichOneFitsYourLifeStyle;
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

            MainPage = new WhichOneFitsYourLifestyleA();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
