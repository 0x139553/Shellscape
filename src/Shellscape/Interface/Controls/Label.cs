using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shellscape.Interface.Style.Brushes;

namespace Shellscape.Interface.Controls
{
	public class Label : ContentControl<string>
	{
		public Brush ForegroundBrush { get; set; }
	}
}
