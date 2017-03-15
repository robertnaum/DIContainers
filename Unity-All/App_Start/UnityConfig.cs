using System.Web.Mvc;
using Microsoft.Practices.Unity;
using System.Web.Http;

namespace Unity_All
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            //var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            //this file is deprecated.  Moved all DI registration into 1 file. UnityWebFormsStart.cs
        }
    }
}