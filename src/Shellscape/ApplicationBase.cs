using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shellscape
{
	public abstract class ApplicationBase
	{

		internal void Startup(string[] arguments)
		{
			OnStartup(arguments);
		}

		internal void Shutdown(int exitCode)
		{
			OnShutdown(exitCode);
			Environment.Exit(exitCode);
		}


		protected virtual void OnStartup(string[] arguments)
		{
			
		}

		protected virtual void OnShutdown(int exitCode)
		{
			
		}

		protected void DisplayViewFor<TViewModel>()
			where TViewModel : IViewModel, new()
		{
			new TViewModel();
			new ViewLocator().LocateViewFor<TViewModel>();
		}

	}
}
