using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shellscape.Example
{
	public class ExampleApplication : ApplicationBase
	{
		protected override void OnStartup(string[] arguments)
		{
			DisplayViewFor<TestViewModel>();
		}
	}
}
