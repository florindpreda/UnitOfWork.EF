using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace UnitOfWork.EF.API
{
    public static class UnityConfig
    {
		private static UnityContainer _container = new UnityContainer();

        public static void RegisterComponents()
        {
			UnitOfWork.EF.DependencyResolver.UnityConfig.RegisterComponents(_container);
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(_container);
        }

		public static UnityContainer Container
		{
			get
			{
				return _container;
			}
		}
    }
}