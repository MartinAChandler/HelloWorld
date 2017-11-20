using HWServiceInterface;
using HWServiceLayer;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace HWWebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IHWService, HWService>();           
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}