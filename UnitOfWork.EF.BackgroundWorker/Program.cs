using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.EF.BackgroundWorker.Startup;
using Microsoft.Practices.Unity;
using UnitOfWork.EF.Core;
using System.Threading;

namespace UnitOfWork.EF.BackgroundWorker
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				UnityConfig.RegisterComponents();

				var worker = UnityConfig.Container.Resolve<Worker>();
				worker.Run();

				Thread.Sleep(5000);
			}			
		}
	}
}