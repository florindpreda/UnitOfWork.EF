using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.EF.Application.Commands
{
	public class DeleteProductCommand
	{
		public Guid Id { get; set; }
	}
}
