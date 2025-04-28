using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp6.Models;

namespace WindowsFormsApp6.DBConnection
{
	internal class DatabaseHelper
	{
		//строка подключения
		private string connectionString = "Server=sql7.freesqldatabase.com;Database=sql7774967;Uid=sql7774967;Pwd=xrSj6CWVCC;Charset=utf8mb4";
		
		//регистация пользователя (добавление нового пользователя в базу данных)
		public bool RegisterUser(User user)
		{
			using (var connection = new MySqlConnection(connectionString))
			{
				connection.Open();

				// Проверка существования пользователя
				var checkCmd = new MySqlCommand("SELECT COUNT(*) FROM User WHERE login = @login", connection);
				checkCmd.Parameters.AddWithValue("@login", user.Name);

				if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
					return false;

				

				// Регистрация
				var insertCmd = new MySqlCommand(
					"INSERT INTO User (login, password, balance) VALUES (@login, @password, @balance)",
					connection);

				insertCmd.Parameters.AddWithValue("@login", user.Name);
				insertCmd.Parameters.AddWithValue("@password", user.Password);
				insertCmd.Parameters.AddWithValue("@balance", user.Balance);

				return insertCmd.ExecuteNonQuery() > 0;
			}
		}
		//Извлечение данных из базы данных в класс User (Вход пользователя в программу)
		public User LoginUser(string name, string password)
		{
			using (var connection = new MySqlConnection(connectionString))
			{
				connection.Open();
				var cmd = new MySqlCommand(
					"SELECT userID, login, password, balance FROM User WHERE login = @login AND password = @password",
					connection);

				cmd.Parameters.AddWithValue("@login", name);
				cmd.Parameters.AddWithValue("@password", password);

				using (var reader = cmd.ExecuteReader())
				{
					return reader.Read() ? new User
					{
						Id = reader.GetInt32("userID"),
						Name = reader.GetString("login"),
						Password = reader.GetString("password"),
						Balance = reader.GetDecimal("balance")
					} : null;
				}
			}
		}
		//обновление баланса пользователя
		public User UpdateBalance(decimal newBalance, User user)
		{
			using (var connection = new MySqlConnection(connectionString)) 
			{
				connection.Open();
				var changeCmd = new MySqlCommand(
					"UPDATE User SET balance = @balance WHERE User.userID = @Id",
					connection);

				changeCmd.Parameters.AddWithValue("@balance", newBalance.ToString());
				changeCmd.Parameters.AddWithValue("@Id", user.Id);

				var cmd = new MySqlCommand(
					"SELECT balance FROM User WHERE userID = @Id",
				connection);

				cmd.Parameters.AddWithValue("@Id", user.Id);

				using (var reader = cmd.ExecuteReader())
				{
					return reader.Read() ? new User
					{
						Balance = reader.GetDecimal("balance")
					} : null;
				}
			}
		}
		//Извлечение данных из базы данных в класс Order
		public void GetOrderInfo(Order order, int id)
		{
			using (var connection = new MySqlConnection(connectionString))
			{
				connection.Open();
				var cmd = new MySqlCommand(
					"SELECT orderID, ticker AS instrumentID, timestamp, sum FROM Orders JOIN Instrument ON Orders.instrumentID = Instrument.instrumentID WHERE orderID= @id",
					connection);

				cmd.Parameters.AddWithValue("@id", id);
				using (var reader = cmd.ExecuteReader())
				{
					if (reader.Read())
					{
						order.Id = reader.GetInt32("orderID");
						order.Ticker = reader.GetString("instrumentID");
						order.TimeStamp = reader.GetDateTime("timestamp");
						order.Sum = reader.GetDecimal("sum");
					}
				}
			}
		}
		//Извлечение данных из базы данных в класс Instrument
		public void GetTickerInfo(Models.Instrument instrument, int id)
		{
			using (var connection = new MySqlConnection(connectionString))
			{
				connection.Open();
				var cmd = new MySqlCommand(
					"SELECT instrumentID, currPrice, ticker FROM Instrument WHERE instrumentID = @id",
					connection);

				cmd.Parameters.AddWithValue("@id", id);
				using (var reader = cmd.ExecuteReader())
				{
					if (reader.Read())
					{
						instrument.Id = reader.GetInt32("instrumentID");
						instrument.Ticker = reader.GetString("ticker");
						instrument.CurrPrice = reader.GetDecimal("currPrice");
					}
				}
			}
		}
		//добавление ордера в таблицу
		public Models.Instrument OrderRequest(int Uid, int Tid, decimal quantity, string status, decimal sum)
		{
			using (var connection = new MySqlConnection(connectionString))
			{
				connection.Open();
				var insertCmd = new MySqlCommand(
					"INSERT INTO Orders (quantity, sum, status, userID, instrumentID) VALUES (@quantity, @sum, @status, @Uid, @Tid)",
					connection);

				insertCmd.Parameters.AddWithValue("@quantity", quantity);
				insertCmd.Parameters.AddWithValue("@sum", sum);
				insertCmd.Parameters.AddWithValue("@status", status);
				insertCmd.Parameters.AddWithValue("@Uid", Uid);
				insertCmd.Parameters.AddWithValue("@Tid", Tid);

				int rowsAffected = insertCmd.ExecuteNonQuery();
				return null;
			}
		}
		//проверка на существование тикера в базе данных
		public bool CheckInstrumentExists(int instrumentId)
		{
			using (var connection = new MySqlConnection(connectionString))
			{
				connection.Open();
				var cmd = new MySqlCommand(
					"SELECT COUNT(*) FROM Instrument WHERE instrumentID = @id",
					connection);
				cmd.Parameters.AddWithValue("@id", instrumentId);
				return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
			}
		}
		//заполнение ListBox существующими ордерами
		public List<string> FillOrders(int id)
		{
			List<string> orders = new List<string>();
			using (var connection = new MySqlConnection(connectionString))
			{
				connection.Open();
				var cmd = new MySqlCommand(
					"SELECT ticker AS InstrumentID, status, orderID FROM Orders JOIN Instrument ON Orders.instrumentID = Instrument.instrumentID WHERE UserID = @id",
					connection);

				cmd.Parameters.AddWithValue("@id", id);

				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						string item = $"{reader["orderID"]} {reader["instrumentID"]} - {reader["status"]}";
						orders.Add(item);
					}
				}
			}

			return orders;
		}
		//удаление ордера
		public bool DeleteOrder(int Id)
		{
			using (var connection = new MySqlConnection(connectionString))
			{
				connection.Open();
				var cmd = new MySqlCommand(
					"DELETE FROM Orders WHERE orderID = @orderID",
					connection);
				cmd.Parameters.AddWithValue("@orderID", Id);

				int rowsAffected = cmd.ExecuteNonQuery();
				return rowsAffected > 0;
			}
		}
	}
}
