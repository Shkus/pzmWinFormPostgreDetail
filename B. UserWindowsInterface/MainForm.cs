using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace pzmWinFormPostgre
{
	public partial class MainForm : Form
	{
		private LoadDeviceInListFromDB LDLFDB { get; set; } = new LoadDeviceInListFromDB();
		public List<Device> devicesList { get; set; } = new List<Device>();
		public LoadItemsInListFromDB LILFDB { get; set; } = new LoadItemsInListFromDB();
		public List<Item> itemsList { get; set; } = new List<Item>();

		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Метод, при загрузке окна обеспечивает загрузку Механизмов и Деталей с отраженим их в DatagridView 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void MainForm_Load(object sender, EventArgs e)
		{
			LDLFDB.LoadDevice(devicesList);
			DGV_loadDetails.DataSource = devicesList;
			LILFDB.LoadItems(itemsList);
			DGV_loadItem.DataSource = itemsList;

		}

		//private void DGV_loadDetails_RowEnter(object sender, DataGridViewCellEventArgs e)
		//{
		//	try
		//	{
		//		if (e.RowIndex < 0)
		//			return;

		//		MainContainer.SelectDetal(DGV_Detal.Rows[e.RowIndex].DataBoundItem);
		//	}
		//	catch (Exception exp)
		//	{
		//		MessageBox.Show(exp.ToString());
		//	}

		//	/// <summary>
		//	/// Выбранная деталь из таблицы
		//	/// </summary>
		//public Detal SelectedDetal { get; set; }

		///// <summary>
		///// Устанавливает выбранную деталь
		///// </summary>
		///// <param name="detal"></param>
		//public void SelectDetal(object detal)
		//{
		//	SelectedDetal = (Detal)detal;
		//}
	}
}
