using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pzmWinFormPostgre
{
	public class LoadDeviceInListFromDB
	{
		public List<Device> deviceList { get; set; } = new List<Device>();
		public void LoadDevice(List<Device> device)
		{			
			try
			{
				//NpgsqlConnection connection = new NpgsqlConnection();

				string connectionString = "Host=localhost;Port=5432;Database=test_dbCsharpPzm;User Id=postgres;Password=123456789abc";
				NpgsqlConnection connectionDB = new NpgsqlConnection(connectionString);

				connectionDB.Open();
				NpgsqlCommand command = new NpgsqlCommand()
				{
					Connection = connectionDB,
					CommandType = System.Data.CommandType.Text,
					CommandTimeout = 3,
					CommandText = "SQL",
				};

				NpgsqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					// Из БД
					Device newDevice = new Device(
						reader["device_id"],
						reader["name_device"],
						reader["manufacturer_device"],
						reader["date_release"],
						reader["size_device"],
						reader["weight_device"],
						reader["price_device"],
						reader["date_added_device"]
						);

					device.Add(newDevice);
				}
			}
			catch (Exception exp)
			{
				MessageBox.Show(exp.ToString());
			}

		}


	}
}
