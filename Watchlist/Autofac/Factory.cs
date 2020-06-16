using Autofac;
using Watchlist.ViewModels;
using Watchlist.ViewModels.Interfaces;

namespace Watchlist.Autofac
{
    public class Factory
    {
        private readonly IContainer container;

        public Factory()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule(new ViewModule());
            container = containerBuilder.Build();
        }

        public MainViewModel MainViewModel
        {
            get { return container.Resolve<MainViewModel>(); }
        }

        //public IViewModel CurrentView
        //{
        //    get { return container.Resolve<IViewModel>(); }
        //}
    }
}
