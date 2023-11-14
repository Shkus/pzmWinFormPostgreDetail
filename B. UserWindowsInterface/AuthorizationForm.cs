using Npgsql;
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
	public partial class AuthorizationForm : Form
	{
		

		public AuthorizationForm()
		{
			InitializeComponent();
		}

		public void btnAuthorization_Click(object sender, EventArgs e)
		{
			LoadDeviceInListFromDB loadDeviceInList = new LoadDeviceInListFromDB();
			string connectionString = "Host=localhost;Port=5432;Database=test_dbCsharpPzm;User Id=postgres;Password=123456789abc";
			NpgsqlConnection connectionDB = new NpgsqlConnection(connectionString);

			string loginUsers = loginField.Text;
			string passwordUsers = passwordField.Text;

			try
			{
				connectionDB.Open();

				DataTable usertable = new DataTable();

				NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();

				// Выполнение команд SQL
				NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM users WHERE login = @uL AND pass_word = @uP", connectionDB);
				command.Parameters.Add("@uL", NpgsqlTypes.NpgsqlDbType.Varchar).Value = loginUsers;
				command.Parameters.Add("@uP", NpgsqlTypes.NpgsqlDbType.Varchar).Value = passwordUsers;

				adapter.SelectCommand = command;
				adapter.Fill(usertable);

				if (usertable.Rows.Count > 0)
				{
					this.Hide();
					//loadDeviceInList.LoadDevice(deviceList);
					MainForm mainForm = new MainForm();
					mainForm.Show();				

				}
				else
				{
					MessageBox.Show("Пользователь не найден. Пароль или логин не совпадают");
				}
				connectionDB.Close();
			}


			catch (Exception ex)
			{
				MessageBox.Show("Ошибка подключения к базе данных");
			}


		}
	}
}




			