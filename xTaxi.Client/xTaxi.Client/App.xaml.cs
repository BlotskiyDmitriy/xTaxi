﻿using Xamarin.Forms;
using xTaxi.Client.Pages;
using xTaxi.Client.Services;
using xTaxi.Client.Services.HttpApi.UoW;
using xTaxi.Client.Services.LoaclDB;
using xTaxi.Client.Services.Logger;
using xTaxi.Client.Services.LoginServices;
using xTaxi.Client.Utils;
using xTaxi.Client.Views;

namespace xTaxi.Client
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            GoogleMapsApiService.Initialize(Constants.Constants.GoogleMapsApiKey);
            RegisterDependencies();
            MainPage = new AppShell();
        }

        private void RegisterDependencies()
        {
            DependencyResolver.Register<DBService>();
            DependencyResolver.Register<LogService>();
            DependencyResolver.Register<PaymentService>();
            DependencyResolver.Register<LoginService>();
            DependencyResolver.Register<UnitOfWork>();
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
