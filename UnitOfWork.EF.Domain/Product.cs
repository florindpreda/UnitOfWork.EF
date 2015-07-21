using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.EF.Core;

namespace UnitOfWork.EF.Domain
{
    public class Product : Entity
    {		
		public string Name { get; private set; }

		protected Product()
		{}

		public Product(string name)
		{		
			this.Name = name;
		}
    }
}
