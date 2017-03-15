using System.Web.Mvc;
using BusinessLibrary;
using Microsoft.Practices.Unity;
using Unity.Mvc5;

namespace Unity___MVC5
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IDrivable, SportsCar>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}