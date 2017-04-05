using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Rhythm.Event.Repository.Interfaces;
using Rhythm.Event.Repository.Realizations;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;

namespace Rhythm.Event.WebAPI
{
    public class IoCConfig
    {
        public static void RegisterContainer()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();
            container.Register<IRhythmEventRepository, RhythmEventRepository>(Lifestyle.Scoped);
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            container.Verify();
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}