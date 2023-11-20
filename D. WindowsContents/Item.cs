using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pzmWinFormPostgre
{
	public class Item : ParentForItemAndDevice
	{
		public string SerialNumber { get; set; }
		public string ColorItem { get; set; }		


		public Item(object id, object name, object serialnumber, object manufacture, object color, object price, object dateAdd)
			: base(id, name, manufacture, price, dateAdd)
		{
			Id = int.TryParse(id.ToString(), out int r1) ? r1 : 0;
			Name = name.ToString();
			Manufacture = manufacture.ToString();
			Price = double.TryParse(price.ToString(), out double r2) ? r2 : 0;
			DateAdd = dateAdd.ToString();
			SerialNumber = serialnumber.ToString();
			ColorItem = color.ToString();
			
		}

	}
}
