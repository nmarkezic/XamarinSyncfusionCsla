using Csla.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinSyncfusionCsla
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            CslaConfiguration.Configure().ContextManager(new Csla.Xaml.ApplicationContextManager());
            var services = new ServiceCollection();
            services.AddCsla();

            MainPage = new LoginPage();
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
