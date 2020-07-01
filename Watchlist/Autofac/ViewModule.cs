using Autofac;
using Watchlist.Data;
using Watchlist.ViewModels;

namespace Watchlist.Autofac
{
    public class ViewModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<XmlSerializer>();
            builder.RegisterType<SeriesSerializer>(); // Why does this work? Because I registered "XmlSerializer"?

            builder.Register<Counter>(Icc =>
            {
                return new Counter(10); // ToDo: Save counter current Id too
            }).SingleInstance();

            //builder.Register<Manager>(Icc =>                        // Not need do everything you need in it's
            //{                                                       // own class and inject into MainViewModel
            //    return new Manager(Icc.Resolve<XmlSerializer>());   // into the Class that needs it.
            //}).SingleInstance();                                    // With that I should get rid of SingleInstance

            builder.Register<MainViewModel>(Icc =>
            {
                return new MainViewModel(Icc.Resolve<SeriesSerializer>(),
                                         Icc.Resolve<Counter>());
            });
        }
    }
}
