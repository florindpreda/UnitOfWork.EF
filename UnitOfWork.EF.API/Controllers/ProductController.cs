using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UnitOfWork.EF.Application;
using UnitOfWork.EF.Application.Commands;

namespace UnitOfWork.EF.API.Controllers
{
	public class ProductController : ApiController
	{
		private readonly IProductService _productService;

		public ProductController(IProductService productService)
		{
			_productService = productService;
		}

		// GET api/values
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/values/5
		public string Get(int id)
		{
			return "value";
		}

		// POST api/values
		public void Post([FromBody]string value)
		{
		}

		// PUT api/values/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/values/5
		public IHttpActionResult Delete([FromUri]DeleteProductCommand command)
		{
			_productService.Delete(command);
			return Ok();
		}
	}
}
