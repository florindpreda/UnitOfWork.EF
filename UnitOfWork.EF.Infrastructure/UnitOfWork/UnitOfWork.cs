using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.EF.Core;

namespace UnitOfWork.EF.Infrastructure
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly IDatabaseContext _databaseContext;

		public UnitOfWork(IDatabaseContext databaseContext)
		{
			_databaseContext = databaseContext;
		}

		public void Commit()
		{
			_databaseContext.SaveChanges();
		}
	}
}