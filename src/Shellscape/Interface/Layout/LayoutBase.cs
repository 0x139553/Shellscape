using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shellscape.Interface.Layout
{
	public abstract class LayoutBase : ViewElementBase
	{

		public List<ViewElementBase> Children { get; set; } 

	}
}
