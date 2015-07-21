using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.EF.Domain;

namespace UnitOfWork.EF.Infrastructure
{
	public class ProductRepository: IProductRepository
	{
		private readonly IDatabaseContext _databaseContext;

		public ProductRepository(IDatabaseContext databaseContext)
		{
			_databaseContext = databaseContext;
		}		

		public Product GetById(Guid productId)
		{
			return _databaseContext.Products.SingleOrDefault(p => p.Id == productId);
		}

		public void Update(Product product)
		{
			_databaseContext.Entry(product).State = System.Data.Entity.EntityState.Modified;
		}		
	}
}
