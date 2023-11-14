using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pzmWinFormPostgre
{
	public partial class MainForm : Form
	{
		public List<Device> deviceList { get; set; } = new List<Device>();
		private LoadDeviceInListFromDB LoadDeviceInListFromDB { get; set; } = new LoadDeviceInListFromDB();


		public MainForm()
		{
			InitializeComponent();

			DGV_loadDetails.DataSource = LoadDeviceInListFromDB.deviceList;

		}

		private void MainForm_Load(object sender, EventArgs e)
		{

			try
			{
				LoadDeviceInListFromDB.LoadDevice(deviceList);
			}
			catch (Exception exp)
			{
				MessageBox.Show(exp.ToString());
			}
		}


	}
}
