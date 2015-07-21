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
		private bool _disposed = false;

		public UnitOfWork(IDatabaseContext databaseContext)
		{
			_databaseContext = databaseContext;
		}

		public void Commit()
		{
			if (_disposed)
			{
				throw new ObjectDisposedException(this.GetType().FullName);
			}
			
			_databaseContext.SaveChanges();
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (_disposed) return;

			if (disposing && _databaseContext != null)
			{
				_databaseContext.Dispose();
			}

			_disposed = true;
		}
	}
}