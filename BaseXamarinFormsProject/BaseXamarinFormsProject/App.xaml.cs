using System;
using BaseXamarinFormsProject.Services;
using BaseXamarinFormsProject.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BaseXamarinFormsProject
{
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public App ()
        {
            InitializeComponent();

            SetupServices();

            MainPage = new MainPage();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }

        private void SetupServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IWebService, WebService>();
            services.AddSingleton<INavigationService, NavigationService>();

            services.AddTransient<MainPageViewModel>();

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}

