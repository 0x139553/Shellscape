using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shellscape.Interface.Controls
{

	public class ContentControl<TContentType> : ContentControl
	{
	
		public new TContentType Content { get; set; }

	}

	public class ContentControl : Control
	{

		public object Content { get; set; }

		public Type ContentType
		{
			get { return HasContent ? Content.GetType() : null; }
		}

		public bool HasContent
		{
			get { return Content != null; }
		}

	}
}
