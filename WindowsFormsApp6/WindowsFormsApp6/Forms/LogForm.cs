using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.DBConnection;
using WindowsFormsApp6.Models;

namespace WindowsFormsApp6
{
	public partial class LogForm : Form
	{
		private DatabaseHelper dbHelper = new DatabaseHelper();
		private bool isLoginMode = true;

		private void SwitchMode()
		{
			isLoginMode = !isLoginMode;

			lblTitle.Text = isLoginMode ? "Вход" : "Регистрация";
			btnSubmit.Text = isLoginMode ? "Войти" : "Зарегистрироваться";
			lblSwitchMode.Text = isLoginMode ? "Нет аккаунта? Зарегистрируйтесь" : "Уже есть аккаунт? Войдите";

		}

		private void OpenMainForm(User user)
		{
			this.Hide();
			var mainForm = new FormMain(user);
			mainForm.ShowDialog();
		}
		private void btnSubmit_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			decimal randBalance = rnd.Next(10000, 1000001);

			if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
			{
				MessageBox.Show("Заполните все поля!");
				return;
			}

			if (isLoginMode)
			{
				// Вход
				var user = dbHelper.LoginUser(txtUsername.Text, txtPassword.Text);

				if (user != null)
				{
					MessageBox.Show($"Добро пожаловать, {user.Name}!");
					OpenMainForm(user);
				}
				else
				{
					MessageBox.Show("Неверные данные!");
				}
			}
			else
			{
				// Регистрация
				var newUser = new User
				{
					Name = txtUsername.Text,
					Password = txtPassword.Text,
					Balance = randBalance
				};

				if (dbHelper.RegisterUser(newUser))
				{
					MessageBox.Show("Регистрация успешна!");
					OpenMainForm(newUser);
				}
				else
				{
					MessageBox.Show("Пользователь уже существует!");
				}
			}
		}
		public LogForm()
		{
			InitializeComponent();
		}


		private void LogForm_Load(object sender, EventArgs e)
		{

		}
		//изменение режима (регистация/вход)
		private void lblSwitchMode_Click(object sender, EventArgs e)
		{
			SwitchMode();
		}
	}
}
