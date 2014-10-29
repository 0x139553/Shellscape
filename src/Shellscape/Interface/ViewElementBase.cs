using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shellscape.Interface.Style;
using Shellscape.Interface.Style.Brushes;

namespace Shellscape.Interface
{
	public abstract class ViewElementBase
	{

		public int Width { get; set; }
		public int Height { get; set; }
		public int MinWidth { get; set; }
		public int MinHeight { get; set; }
		public int MaxWidth { get; set; }
		public int MaxHeight { get; set; }

		public Brush BackgroundBrush { get; set; }

		public Thickness Margin { get; set; }
		public Thickness Padding { get; set; }

		public HorizontalAlignment HorizontalAlignment { get; set; }
		public VerticalAlignment VerticalAlignment { get; set; }

	}
}
