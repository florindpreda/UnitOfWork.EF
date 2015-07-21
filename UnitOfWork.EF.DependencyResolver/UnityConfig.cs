using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using UnitOfWork.EF.Application;
using UnitOfWork.EF.Core;
using UnitOfWork.EF.Domain;
using UnitOfWork.EF.Infrastructure;

namespace UnitOfWork.EF.DependencyResolver
{
    public class UnityConfig
    {
		public static void RegisterComponents(UnityContainer container)
		{			
			if (HttpContext.Current != null)
			{
				container.RegisterType<IDatabaseContext, DatabaseContext>(new PerHttpRequestLifetimeManager());
			}
			else
			{				
				container.RegisterType<IDatabaseContext, DatabaseContext>(new ContainerControlledLifetimeManager());
			}

			container.RegisterType<IUnitOfWork, UnitOfWork.EF.Infrastructure.UnitOfWork>();
			container.RegisterType<IProductRepository, ProductRepository>();
			container.RegisterType<IProductReviewRepository, ProductReviewRepository>();
			container.RegisterType<IProductService, ProductService>();
			container.RegisterType<IDatabaseConfiguration, EntityFrameworkConfiguration>();
		}
    }
}