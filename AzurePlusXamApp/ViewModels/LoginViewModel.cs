using System;
using System.Threading.Tasks;
using AzurePlusXamApp.Views;
using Prism.Navigation;
using Xamarin.Forms;

namespace AzurePlusXamApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        string username;
        string password;
        public Command AuthenticateUserCommand { get; }
        public Command ForgotPasswordCommand { get; }
        public Command SignUpCommand { get; }

        public LoginViewModel(INavigationService navigationService) : base(navigationService)
        {
            AuthenticateUserCommand = new Command(async () => await Authenticate(), () => !IsBusy);
        }

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

        async Task Authenticate()
        {
            IsBusy = true;
            await Task.Delay(4000);

            IsBusy = false;
            AuthenticateUserCommand.ChangeCanExecute();
            //await Navigation.PopAsync();
            //await Navigation.PushAsync(new MainTabPage());
        }
    }
}
