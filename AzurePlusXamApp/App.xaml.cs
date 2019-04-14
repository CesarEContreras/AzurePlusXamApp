using System;
using AzurePlusXamApp.Helpers;
using AzurePlusXamApp.ViewModels;
using AzurePlusXamApp.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Push;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AzurePlusXamApp
{
    public partial class App : PrismApplication
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync(NavigationConstants.WelcomePage);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<WelcomePage, WelcomePageViewModel>();
            containerRegistry.RegisterForNavigation<LoginA, LoginViewModel>();
            containerRegistry.RegisterForNavigation<WhichOneFitsYourLifestyle, WhichOneFitsYourLSViewModel>();
            containerRegistry.RegisterForNavigation<MainTabPage>();
        }
    }
}
