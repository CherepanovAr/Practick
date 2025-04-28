using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.DBConnection;
using WindowsFormsApp6.Models;

namespace WindowsFormsApp6.Forms
{

	public partial class FormOrder : Form
	{
		private DatabaseHelper dbHelper = new DatabaseHelper();
		private Models.Instrument instrument = new Models.Instrument();
		private User currentUser;
		private int index;
		public decimal sum;
		public decimal currBalance;
		public event EventHandler OrderFormClosed;

		public FormOrder(User user)
		{
			InitializeComponent();
			currentUser = user;
			currBalance = currentUser.Balance;
	}

		private void Form2_Load(object sender, EventArgs e)
		{
		}

		//расчитывает итоговую сумму ордера
		private void numQuantity_ValueChanged(object sender, EventArgs e)
		{
		    dbHelper.GetTickerInfo(instrument, index);
			sum = instrument.CurrPrice * numQuantity.Value;
			lblSum.Text = sum.ToString();
		}
		//определяет порядковый номер ордера для работы с базой данных
		private void comBoxTicker_SelectedIndexChanged(object sender, EventArgs e)
		{
			index = comBoxTicker.SelectedIndex + 1;

		}
		//добавляет ордер в базу данных
		private void btnBuy_Click(object sender, EventArgs e)
		{
			if (currentUser.Balance >= sum)
			{
				var instrumentExists = dbHelper.CheckInstrumentExists(instrument.Id);
				if (!instrumentExists)
				{
					MessageBox.Show("Ошибка: указанный тикер не найден "+instrument.Id);
					return;
				}
				currentUser.Balance -= sum;
				dbHelper.UpdateBalance(currentUser.Balance, currentUser);
				dbHelper.OrderRequest(currentUser.Id, index , numQuantity.Value, "Исполняется", sum);
				MessageBox.Show("Ордер создан");
				Close();
			}
			else 
			{
				MessageBox.Show("У вас недостаточно средств");
			}
		}
		private void btnBack_Click(object sender, EventArgs e)
		{
			Close();
		}
		//создаёт событие при закрытии формы
		private void FormOrder_FormClosed(object sender, FormClosedEventArgs e)
		{
			OrderFormClosed?.Invoke(this, EventArgs.Empty);
		}
	}
}
