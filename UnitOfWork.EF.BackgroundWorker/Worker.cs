using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.EF.Application;
using UnitOfWork.EF.Application.Commands;
using UnitOfWork.EF.Core;

namespace UnitOfWork.EF.BackgroundWorker
{
	public class Worker : IWorker
	{
		private readonly IProductService _productService;

		public Worker(IProductService productService)
		{
			_productService = productService;
		}

		public void Run()
		{
			var productId = Guid.Parse("287278A8-AA52-4B34-A96F-5C94967F3C58");//replace with an actual product Id from the database
			var deleteProductCommand = new DeleteProductCommand() { Id = productId };

			_productService.Delete(deleteProductCommand);
		}
	}
}
