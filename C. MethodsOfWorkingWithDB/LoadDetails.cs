using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace pzmWinFormPostgre
{
	internal class LoadDetails
	{
		public void LoadDetals(List<Device> device)
		{
			try
			{

				NpgsqlConnection connection = new NpgsqlConnection();

				connection.Open();
				NpgsqlCommand command = new NpgsqlCommand()
				{
					Connection = connection,
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
