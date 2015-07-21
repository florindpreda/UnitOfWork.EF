using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.EF.DependencyResolver
{
	public class PerBackgroundWorkerRequestLifetimeManager : LifetimeManager
	{
		private readonly Guid _key = Guid.NewGuid();
		private static IDictionary<Guid, object> _requestContext = new Dictionary<Guid, object>();

		public override object GetValue()
		{
			object context = null;
			_requestContext.TryGetValue(_key, out context);

			return context;
		}

		public override void SetValue(object newValue)
		{
			_requestContext[_key] = newValue;
		}

		public override void RemoveValue()
		{
			_requestContext.Remove(_key);
		}
	}
}
