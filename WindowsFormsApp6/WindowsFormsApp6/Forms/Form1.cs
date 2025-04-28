using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using WindowsFormsApp6.DBConnection;
using WindowsFormsApp6.Models;

namespace WindowsFormsApp6
{
	public partial class FormMain : Form
	{
		private User currentUser;
		private DatabaseHelper dbHelper = new DatabaseHelper();
		private Order order = new Order();
		//обновляет баланс пользователя
		public void ReloadBalance() 
		{
			lblBalance.Text = "Баланс: " + currentUser.Balance.ToString() + '$';
		}
		//загружает listBox ордеров
		private void LoadOrders() 	
		{
			List<string> orders = dbHelper.FillOrders(currentUser.Id);
			listOrder.Items.Clear();
			listOrder.Items.AddRange(orders.ToArray());
		}
		//заполняет поля информации об ордере
		private void FillLabel() 
		{
			lblOrderId.Text = order.Id.ToString();
			lblTicker.Text = order.Ticker;
			lblTimeStamp.Text = order.TimeStamp.ToString();
			lblSum.Text = order.Sum.ToString()+"$";
		}
		public FormMain(User user)
		{
			currentUser = user;
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lblName.Text = "Имя пользователя: "+currentUser.Name;
			LoadOrders();
			ReloadBalance();
		}
		//заполняет поля информацией о выбранном ордере
		private void listOrder_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listOrder.SelectedItem != null)
			{
				string selectedItem = listOrder.SelectedItem.ToString();

				string[] parts = selectedItem.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

				if (parts.Length > 0 && int.TryParse(parts[0], out int Id))
				{
					dbHelper.GetOrderInfo(order, Id);
					FillLabel();
				}
			}
		}
		//вызов формы создания ордера
		private void btnCreateOrder_Click(object sender, EventArgs e)
		{
			using (var orderForm = new Forms.FormOrder(currentUser))
			{
				orderForm.OrderFormClosed += (s, args) =>
				{
					ReloadBalance();  
					LoadOrders();   
				};
				orderForm.ShowDialog();
			}
		}
		//удаление выбранного ордера
		private void btnDeleteOrder_Click(object sender, EventArgs e)
		{
			if (listOrder.SelectedItem != null)
			{
				string selectedItem = listOrder.SelectedItem.ToString();

				string[] parts = selectedItem.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

				if (parts.Length > 0 && int.TryParse(parts[0], out int Id))
				{
					try
					{
						listOrder.Items.Remove(listOrder.SelectedItem);
						dbHelper.DeleteOrder(Id);

					}
					catch (Exception ex)
					{
						MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

	}
}
