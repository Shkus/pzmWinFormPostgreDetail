using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace pzmWinFormPostgre
{
	public class LoadItemsInListFromDB
	{
		/// <summary>
		/// Метод загрузки Деталей из базы данных
		/// </summary>
		/// <param name="itemList">список деталей</param>
		public void LoadItems(List<Item> itemList)
		{			
			try
			{
				string connectionString = "Host=localhost;Port=5432;Database=test_dbCsharpPzm;User Id=postgres;Password=123456789abc";
				NpgsqlConnection connectionDB = new NpgsqlConnection(connectionString);

				connectionDB.Open();
				NpgsqlCommand command = new NpgsqlCommand()
				{
					Connection = connectionDB,
					CommandType = System.Data.CommandType.Text,
					CommandTimeout = 3,
					CommandText = "SELECT * FROM item",
				};

				NpgsqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					// Из БД
					Item newItem = new Item(
						reader["item_id"],
						reader["name_item"],
						reader["serialnumber_item"],
						reader["manufacturer_item"],
						reader["color_item"],
						reader["price_item"],
						reader["date_added_item"]						
						);

					itemList.Add(newItem);
					
				}
			}
			catch (Exception exp)
			{
				MessageBox.Show(exp.ToString());
			}			

		}


	}
}
