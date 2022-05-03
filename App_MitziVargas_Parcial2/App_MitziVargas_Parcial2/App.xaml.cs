using App_MitziVargas_Parcial2.Services;
using App_MitziVargas_Parcial2.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_MitziVargas_Parcial2
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();

            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
