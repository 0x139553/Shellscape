using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shellscape
{
	public static class Shell
	{

		private static string[] _arguments;

		public static ApplicationBase ApplicationInstance { get; private set; }

		public static string[] Arguments
		{
			get { return _arguments ?? (_arguments = Environment.GetCommandLineArgs()); }
		}

		public static void RunApplication<TApplication>()
			where TApplication : ApplicationBase
		{
			ApplicationInstance = Activator.CreateInstance<TApplication>();
			if(ApplicationInstance == null)
				throw new InvalidOperationException();

			ApplicationInstance.Startup(Arguments);
		}

	}
}
