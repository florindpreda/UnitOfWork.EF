using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.EF.Domain;

namespace UnitOfWork.EF.Infrastructure
{
	public class DatabaseContext : DbContext, IDatabaseContext
	{
		public IDbSet<Product> Products { get; set; }
		public IDbSet<ProductReview> ProductReviews { get; set; }

		public DatabaseContext() : base("DatabaseConnectionString")
		{
			
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
