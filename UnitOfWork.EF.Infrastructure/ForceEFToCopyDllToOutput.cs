using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.EF.Infrastructure
{
	internal static class ForceEFToCopyDllToOutput
	{
		private static SqlProviderServices instance = SqlProviderServices.Instance;
	}
}
