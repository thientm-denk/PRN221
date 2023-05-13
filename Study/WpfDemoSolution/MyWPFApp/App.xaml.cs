using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MyWPFApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
        }
        //private void OnStartup(object sender, StartupEventArgs e)
        //{
        //    var mainWindow = _serviceProvider.GetService<MainWindow>();
        //    mainWindow.Show();
        //}

        protected override void OnStartup(StartupEventArgs e)
        {
            //var mainWindow = _serviceProvider.GetService<MainWindow>();
            //mainWindow.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
           // MessageBox.Show("Test");
        }

        //private void OnExit(object sender, StartupEventArgs e)
        //{
        //    MessageBox.Show("Test");
        //}
    }
}
