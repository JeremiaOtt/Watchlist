using Autofac;
using Watchlist.ViewModels;

namespace Watchlist.Autofac
{
    public class Factory
    {
        private readonly IContainer container;

        public Factory()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule(new SetupModule());
            container = containerBuilder.Build();
        }

        public MainViewModel MainViewModel
        {
            get { return container.Resolve<MainViewModel>(); }
        }
    }
}
