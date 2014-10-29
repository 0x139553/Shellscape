using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shellscape.Interface.Style
{

	public struct Thickness
	{

		private readonly int _left, _right, _top, _bottom;

		public int Left
		{
			get { return _left; }
		}

		public int Right { get { return _right; }  }
		public int Top { get { return _top; } }

		public int Bottom
		{
			get { return _bottom; }
		}

		public Thickness(int overallThickness)
		{
			_left = _right = _bottom = _top = overallThickness;
		}

		public Thickness(int left, int right, int top, int bottom)
		{
			_left = left;
			_top = top;
			_right = right;
			_bottom = bottom;
		}

		public Thickness(int horizontal, int vertical)
		{
			_left = _right = horizontal;
			_bottom = _top = vertical;
		}

	}
}
