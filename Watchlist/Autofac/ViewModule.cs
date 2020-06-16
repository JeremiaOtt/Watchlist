using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Watchlist.ViewModels;
using Watchlist.ViewModels.Interfaces;

namespace Watchlist.Autofac
{
    public class ViewModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<XmlSerializer>();
            //builder.RegisterType<EntryListViewModel>();
            //builder.RegisterType<EntryViewModel>();

            builder.Register<MainViewModel>(Icc =>
            {
                return new MainViewModel(Icc.Resolve<XmlSerializer>());
            }).SingleInstance();

            //builder.Register<IViewModel>(Icc =>
            //{
            //    return Icc.Resolve<MainViewModel>().CurrentView;
            //});
        }
    }
}
