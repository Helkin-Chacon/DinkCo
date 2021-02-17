using LogFinalDink.viewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DinkCo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        public LoginPage()
        {
            
            InitializeComponent();

        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            string email = ((Entry)sender).Text;
        }

        private void GoToRegister(object sender, EventArgs e)
        {
           // Navigation.PushAsync(new RegisterPage());
        }

        private void GoToPrincipal(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new MenusPage());
        }

        protected override async void OnAppearing()
        {
            BindingContext = new LoginPageViewModel();
            base.OnAppearing();
        }
    }
}