using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.EF.Domain;

namespace UnitOfWork.EF.Infrastructure
{
	public interface IDatabaseContext
	{
		IDbSet<Product> Products { get; set; }
		IDbSet<ProductReview> ProductReviews { get; set; }

		int SaveChanges();
		DbEntityEntry Entry(object entity);
		void Dispose();
	}
}
