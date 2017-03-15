using BusinessLibrary;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace Unity_All
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            Unity_All.App_Start.UnityWebFormsStart.RegisterDependencies(container);
           // container.RegisterType(typeof(IDrivable), typeof(Bus), new HierarchicalLifetimeManager());
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}