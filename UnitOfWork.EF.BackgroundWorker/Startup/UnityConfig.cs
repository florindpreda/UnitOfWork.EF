using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.EF.BackgroundWorker.Startup
{
	public static class UnityConfig
	{
		private static UnityContainer _container = new UnityContainer();

		public static void RegisterComponents()
		{
			UnitOfWork.EF.DependencyResolver.UnityConfig.RegisterComponents(_container);		
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
