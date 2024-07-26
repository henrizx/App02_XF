using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPGXF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new App02_TipoPGXF.TipoPagina.Carrosel.TipoPagina3();
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
