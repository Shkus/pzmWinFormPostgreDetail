using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pzmWinFormPostgre
{
	public class Device : ParentForItemAndDevice
	{
		public string DateRelease { get; private set; }
		public string Size { get; private set; }
		public double Weight { get; private set; }


		public Device(object id, object name, object manufacture, object daterelease, 
			object size, object weight, object price, object dateAdd)
			: base(id, name, manufacture, price, dateAdd)
		{

			DateRelease = daterelease.ToString();
			Size = size.ToString();
			Weight = double.TryParse(weight.ToString(), out double r2) ? r2 : 0;
		}
	}
}
