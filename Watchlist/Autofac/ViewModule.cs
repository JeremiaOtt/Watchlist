using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace Watchlist.Autofac
{
    public class ViewModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<XmlFile>();
            builder.Register<Manager>(Icc => 
            {
                return new Manager(Icc.Resolve<XmlFile>());
            }).SingleInstance();
        }
    }
}
