using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pzmWinFormPostgre
{
	public class Item : ParentForItemAndDevice
	{
		public string Serialnumber { get; private set; }
		public string Color { get; private set; }

		public Item(int id, string name, double price, string dateAdd, string manufacture, object serialnumber, object size, object color)
			: base(id, name, price, dateAdd, manufacture)
		{
			Serialnumber = serialnumber.ToString();
			Color = color.ToString();
		}

	}
}
