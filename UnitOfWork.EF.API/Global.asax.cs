using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using UnitOfWork.EF.Core;
using Microsoft.Practices.Unity;

namespace UnitOfWork.EF.API
{
	public class WebApiApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			
			//IoC configurations
			UnityConfig.RegisterComponents();

			GlobalConfiguration.Configure(WebApiConfig.Register);									
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);

			//creates and seeds the database at first run
			UnityConfig.Container.Resolve<IDatabaseConfiguration>().Initialise();
		}
	}
}
