using DinkCo.ViewModels;
using Microsoft.Identity.Client;
using Syncfusion.SfNavigationDrawer.XForms;
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
	public partial class MenusPage : ContentPage
	{
        private AuthenticationResult authenticationResult;
        public MenusPage(AuthenticationResult authResult )
        {
            //Datos del Token
            authenticationResult = authResult;

            InitializeComponent();
            SfNavigationDrawer hola = navigationDrawer1;
         
            bt.Clicked += (object sender, System.EventArgs e) =>
            {
                if (simTab.SelectedIndex == 4)
                {
                    hola.ToggleDrawer();
                    simTab.SelectedIndex = 0;
                }
                else
                {
                    simTab.SelectedIndex = 4;
                    hola.ToggleDrawer();
                }
            };

            Button GoToGeneralButton = new Button();
            GoToGeneralButton.Clicked += OnTapGestureRecognizerTapped1;
        }
        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            if (simTab.SelectedIndex == 4)
            {
                SfNavigationDrawer hola = navigationDrawer1;
                hola.ToggleDrawer();
                simTab.SelectedIndex = 0;
            }
            else
            {
                simTab.SelectedIndex = 0;
            }
        }
        void OnTapGestureRecognizerTapped1(object sender, EventArgs args)
        {
            if (simTab.SelectedIndex == 4)
            {
                SfNavigationDrawer hola = navigationDrawer1;
                hola.ToggleDrawer();
                simTab.SelectedIndex = 1;
            }
            else
            {
                simTab.SelectedIndex = 1;
            }
        }

        void OnTapGestureRecognizerTapped2(object sender, EventArgs args)
        {
            if (simTab.SelectedIndex == 4)
            {
                SfNavigationDrawer hola = navigationDrawer1;
                hola.ToggleDrawer();
                simTab.SelectedIndex = 2;
            }
            else
            {
                simTab.SelectedIndex = 2;
            }
        }
        void OnTapGestureRecognizerTapped3(object sender, System.EventArgs e)
        {
            if (simTab.SelectedIndex == 4)
            {
                SfNavigationDrawer hola = navigationDrawer1;
                hola.ToggleDrawer();
                simTab.SelectedIndex = 3;
            }
            else
            {
                simTab.SelectedIndex = 3;
            }
        }
        private void GoToGeneral(object sender, EventArgs e)
        {

        }

        //Funcion 
        protected override void OnAppearing()
        {
            BindingContext = new MenusPageViewModel(authenticationResult);
            base.OnAppearing();

        }

    }
}
