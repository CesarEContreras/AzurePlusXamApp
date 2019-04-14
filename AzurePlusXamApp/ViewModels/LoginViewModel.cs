using System;
using System.Threading.Tasks;
using AzurePlusXamApp.Helpers;
using AzurePlusXamApp.Views;
using Prism.Commands;
using Prism.Navigation;
using Xamarin.Forms;

namespace AzurePlusXamApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        string username;
        string password;
        private DelegateCommand authenticateUserCommand;
        public DelegateCommand ForgotPasswordCommand { get; }
        public DelegateCommand SignUpCommand { get; }

        public DelegateCommand AuthenticateUserCommand =>
            authenticateUserCommand ?? (authenticateUserCommand = new DelegateCommand(Authenticate));
        public string Username
        {
            get => username;
            set
            {
                username = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }

        public LoginViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        async void Authenticate()
        {
            IsBusy = true;
            await Task.Delay(4000);

            IsBusy = false;
            ExecuteNavigation();
        }

        private async void ExecuteNavigation() => await NavigationService.NavigateAsync(NavigationConstants.MainTabPage);
    }
}
