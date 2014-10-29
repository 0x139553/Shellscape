using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shellscape.Interface
{
	public struct MatrixElement
	{

		private readonly char _character;
		private readonly ConsoleColor _foregroundColor, _backgroundColor;

		public char Character
		{
			get
			{
				return _character;
			}
		}

		public ConsoleColor ForegroundColor
		{
			get { return _foregroundColor; }
		}

		public ConsoleColor BackgroundColor
		{
			get { return _backgroundColor; }
		}

		public MatrixElement(char character, ConsoleColor foregroundColor, ConsoleColor backgroundColor)
		{
			_character			= character;
			_foregroundColor	= foregroundColor;
			_backgroundColor	= backgroundColor;
		}

	}
}
