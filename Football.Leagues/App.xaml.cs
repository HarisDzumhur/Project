﻿using Football.Leagues.Service;
using Football.Leagues.Service.Common;
using Football.Leagues.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Football.Leagues
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider? _serviceProvider;

        public App()
        {
            IServiceCollection service = new ServiceCollection();

            service.AddSingleton<MainWindow>(provider => new MainWindow
            {
                DataContext = provider.GetRequiredService<MainViewModel>()
            });

            service.AddSingleton<MainViewModel>();
            service.AddSingleton<LoginViewModel>();

            service.AddSingleton<INavigationService, NavigationService>();
            service.AddSingleton<Func<Type, ViewModelBase>>(serviceProvider => viewModelType => (ViewModelBase)serviceProvider.GetRequiredService(viewModelType));

            _serviceProvider = service.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindow = _serviceProvider?.GetRequiredService<MainWindow>();
            mainWindow?.Show();
            base.OnStartup(e);
        }

    }

}
