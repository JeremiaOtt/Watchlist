using Autofac;

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

        public Manager Manager
        {
            get { return container.Resolve<Manager>(); }
        }
    }
}
