﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shellscape.Example
{
	public class Program
	{
		private static void Main()
		{

			Shell.RunApplication<ExampleApplication>();
			Console.ReadKey();
		}
	}
}
