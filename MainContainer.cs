using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pzmWinFormPostgre
{
	internal class MainContainer
	{
		#region Список деталей

		/// <summary>
		/// Список деталей
		/// </summary>
		public List<Device> Device { get; set; } = new List<Device>();

		public void LoadDevice(List<Device> device)
		{
			Device.Clear();
			LoadDevice(Device);
		}

		#endregion

		#region Выбранная деталь из таблицы

		/// <summary>
		/// Выбранная деталь из таблицы
		/// </summary>
		//public Device SelectedDetal { get; set; }

		///// <summary>
		///// Устанавливает выбранную деталь
		///// </summary>
		///// <param name="detal"></param>
		//public void SelectDetal(object detal)
		//{
		//    SelectedDetal = (Device)detal;
		//}

		#endregion
	}
}
