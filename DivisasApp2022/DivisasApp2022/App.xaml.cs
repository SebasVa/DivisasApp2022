using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DivisasApp2022
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.ConversorView();
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
