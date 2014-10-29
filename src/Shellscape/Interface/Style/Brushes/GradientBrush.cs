using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shellscape.Interface.Style.Brushes
{
	public class GradientBrush : Brush
	{

		public IList<ConsoleColor> Steps { get; set; }
		public GradientBrushType GradientBrushType { get; set; }

	}
}
