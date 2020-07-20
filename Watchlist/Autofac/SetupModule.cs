using Autofac;
using Watchlist.ViewModels;

namespace Watchlist.Autofac
{
    public class SetupModule : Module
    {
        //private string path = "C:\\Users\\Seischen\\Documents\\Projekte\\Watchlist";
        private readonly string _storageLocationPath = "C:\\Users\\Seischen\\Documents\\watchlistStorage.xml";

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<XmlSerializer>();
            builder.Register<StorageSerializer>(Icc =>
            {
                return new StorageSerializer(Icc.Resolve<XmlSerializer>(), _storageLocationPath);
            });
            builder.RegisterType<MainViewModel>().SingleInstance();
        }
    }
}
