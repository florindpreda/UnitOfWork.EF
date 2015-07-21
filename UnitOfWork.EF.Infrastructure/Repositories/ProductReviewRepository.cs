using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.EF.Domain;

namespace UnitOfWork.EF.Infrastructure
{
    public class ProductReviewRepository: IProductReviewRepository
    {
		private readonly IDatabaseContext _databaseContext;

		public ProductReviewRepository(IDatabaseContext databaseContext)
		{
			_databaseContext = databaseContext;
		}

		public IEnumerable<ProductReview> GetByProductId(Guid productId)
		{
			return _databaseContext.ProductReviews.Where(pr => pr.ProductId == productId);
		}

		public void Update(ProductReview productReview)
		{
			_databaseContext.Entry(productReview).State = System.Data.Entity.EntityState.Modified;
		}
	}
}