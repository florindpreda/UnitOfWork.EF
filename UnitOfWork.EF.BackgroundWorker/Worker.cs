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
			var productId = Guid.Parse("6304AC08-ECF8-44DF-8728-1E8F877E8D6C");//replace with an actual product Id from the database
			var deleteProductCommand = new DeleteProductCommand() { Id = productId };

			_productService.Delete(deleteProductCommand);
		}
	}
}
