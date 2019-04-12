using System;
using AzurePlusXamApp.Helpers;
using Prism.Commands;
using Prism.Navigation;

namespace AzurePlusXamApp.ViewModels
{
    public class WelcomePageViewModel : BaseViewModel
    {
        private DelegateCommand navigateCommand;

        public DelegateCommand NavigateCommand =>
            navigateCommand ?? (navigateCommand = new DelegateCommand(ExecuteNavigateCommand));

        public WelcomePageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        async void ExecuteNavigateCommand()
        {
            await NavigationService.NavigateAsync(NavigationConstants.LoginA);
        }
    }
}
