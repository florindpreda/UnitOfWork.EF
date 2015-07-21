using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.EF.Application.Commands;

namespace UnitOfWork.EF.Application
{
    public interface IProductService
    {
		void Delete(DeleteProductCommand command);
    }
}
