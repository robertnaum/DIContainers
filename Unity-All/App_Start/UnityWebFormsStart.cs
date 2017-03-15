using System.Web;
using Microsoft.Practices.Unity;
using Unity.WebForms;
using BusinessLibrary;

[assembly: WebActivatorEx.PostApplicationStartMethod( typeof(Unity_All.App_Start.UnityWebFormsStart), "PostStart" )]
namespace Unity_All.App_Start
{
	/// <summary>
	///		Startup class for the Unity.WebForms NuGet package.
	/// </summary>
	internal static class UnityWebFormsStart
	{
		/// <summary>
		///     Initializes the unity container when the application starts up.
		/// </summary>
		/// <remarks>
		///		Do not edit this method. Perform any modifications in the
		///		<see cref="RegisterDependencies" /> method.
		/// </remarks>
		internal static void PostStart()
		{
			IUnityContainer container = new UnityContainer();
			HttpContext.Current.Application.SetContainer( container );

			RegisterDependencies( container );
            System.Web.Mvc.DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
            System.Web.Http.GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);

        }

        /// <summary>
        ///		Registers dependencies in the supplied container.
        /// </summary>
        /// <param name="container">Instance of the container to populate.</param>
        public static void RegisterDependencies( IUnityContainer container )
		{
            // TODO: Add any dependencies needed here
            container.RegisterType(typeof(IDrivable), typeof(Bus), new HierarchicalLifetimeManager());

        }
    }
}