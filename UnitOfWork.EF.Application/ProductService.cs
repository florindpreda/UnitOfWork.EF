using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.EF.Application.Commands;
using UnitOfWork.EF.Core;
using UnitOfWork.EF.Domain;

namespace UnitOfWork.EF.Application
{
	public class ProductService : IProductService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IProductRepository _productRepository;
		private readonly IProductReviewRepository _productReviewRepository;

		public ProductService(IUnitOfWork unitOfWork, IProductRepository productRepository, IProductReviewRepository productReviewRepository)
		{
			_unitOfWork = unitOfWork;
			_productRepository = productRepository;
			_productReviewRepository = productReviewRepository;
		}

		public void Delete(DeleteProductCommand command)
		{
			var product = _productRepository.GetById(command.Id);
			product.Delete();
			_productRepository.Update(product);

			var productReviews = _productReviewRepository.GetByProductId(product.Id);
			foreach(var productReview in productReviews)
			{
				productReview.Delete();
				_productReviewRepository.Update(productReview);
			}

			_unitOfWork.Commit();
		}
	}
}