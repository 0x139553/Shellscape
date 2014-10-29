using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shellscape
{
	public class ViewLocator
	{

		public void LocateViewFor<TViewModel>()
			where TViewModel : IViewModel
		{

			var viewModelType = typeof (TViewModel);
			var viewModelName = viewModelType.Name;

			try
			{
				using (var stream = Assembly.GetEntryAssembly().GetManifestResourceStream(viewModelName))
				{
					var xDocument = XDocument.Load(stream);


				}
			}
			catch (Exception ex)
			{
				
			}

		}

	}
}
