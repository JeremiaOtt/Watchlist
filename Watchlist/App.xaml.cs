using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Watchlist
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //private const string RootLifetimeTag = "MyIsolatedRoot";

        //private void App_Startup(object sender, StartupEventArgs e)
        //{
        //    //var serviceCollection = new ServiceCollection();
        //    //serviceCollection.AddLogging();

        //    var containerBuilder = new ContainerBuilder();
        //    //containerBuilder.RegisterType<MessageHandler>().As<IHandler>();
        //    var container = containerBuilder.Build();

        //    using (var scope = container.BeginLifetimeScope(RootLifetimeTag))
        //    {
        //        // This service provider will have access to global singletons
        //        // and registrations but the "singletons" for things registered
        //        // in the service collection will be "rooted" under this
        //        // child scope, unavailable to the rest of the application.
        //        //
        //        // Obviously it's not super helpful being in this using block,
        //        // so likely you'll create the scope at app startup, keep it
        //        // around during the app lifetime, and dispose of it manually
        //        // yourself during app shutdown.
        //        //var serviceProvider = new AutofacServiceProvider(scope);
        //        var mainWin = new MainWindow();
        //        mainWin.DataContext = container.Resolve<Manager>();
        //        mainWin.Show();
        //    }
        //}
        // https://autofaccn.readthedocs.io/en/latest/integration/netcore.html#
    }
}
