using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pzmWinFormPostgre
{
	public class ParentForItemAndDevice
	{
		public int Id { get; protected set; }
		public string Name { get; protected set; }
		public double Price { get; protected set; }
		public string DateAdd { get; protected set; }
		public string Manufacture { get; protected set; }


		public ParentForItemAndDevice(object id, object name, object price, object dateAdd, object manufacture)
		{
			//this.Id = id;
			//this.Name = name;
			//this.Price = price;
			//this.DateAdd = dateAdd;
			//this.Manufacture = manufacture;            

			Id = int.TryParse(id.ToString(), out int r1) ? r1 : 0;
			Name = name.ToString();
			Price = double.TryParse(price.ToString(), out double r2) ? r2 : 0;
			DateAdd = dateAdd.ToString();
			Manufacture = manufacture.ToString();
		}
	}
}
		

