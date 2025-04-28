using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Museum
{
	public partial class Form1 : Form
	{

		private List<Exhibit> exhibits = new List<Exhibit>();
		private int currentExhibitIndex = 0;
		public Form1()
		{
			InitializeComponent();
		}

		private void InitializeExhibits()
		{
			exhibits.Add(new Exhibit(
				"Розеттский камень",
				"Древний Египет, 196 г. до н.э.",
				"Базальтовая плита с идентичным текстом на древнеегипетском иероглифическом, демотическом и древнегреческом языках. Ключ к расшифровке египетских иероглифов.",
				Image.FromFile("img/rosett.jpg"),
			"● Важный археологический артефакт\n● Обнаружен в 1799 году\n● Хранится в Британском музее"));

			exhibits.Add(new Exhibit(
				"Антикитерский механизм",
				"Древняя Греция, 100 г. до н.э.",
				"Древнее механическое устройство для расчёта движения небесных тел. Считается первым аналоговым компьютером в мире.",
				Image.FromFile("img/anti.png"),
				"● Обнаружен в 1901 году\n● Содержит 37 бронзовых шестерён\n● Предсказывает солнечные затмения"));

			exhibits.Add(new Exhibit(
				"Меч Тутанхамона",
				"Древний Египет, 1333-1323 гг. до н.э.",
				"Церемониальный меч фараона Тутанхамона с клинком из метеоритного железа.",
				Image.FromFile("img/sword.png"),
				"● Обнаружен в 1925 году\n● Редкий пример железного оружия бронзового века"));
		}
		private void InitializeUI()
		{
			this.Text = "Виртуальный музей исторических артефактов";
			this.ClientSize = new Size(800, 600);
			this.BackColor = Color.WhiteSmoke;


			// Кнопки навигации
			var btnPrev = new Button
			{
				Text = "◄ Назад",
				Location = new Point(20, 550),
				Size = new Size(100, 30),

			};

			var btnNext = new Button
			{
				Text = "Вперед ►",
				Location = new Point(680, 550),
				Size = new Size(100, 30),

			};

			btnPrev.Click += (s, e) => { currentExhibitIndex--; ShowExhibit(currentExhibitIndex); };
			btnNext.Click += (s, e) => { currentExhibitIndex++; ShowExhibit(currentExhibitIndex); };
			this.Controls.Add(btnPrev);
			this.Controls.Add(btnNext);

		}
		private void ShowExhibit(int index)
		{
			// Обработка границ списка
			if (index < 0) index = exhibits.Count - 1; /*btnPrev.Enabled = false;*/
			if (index >= exhibits.Count) index = 0;
			currentExhibitIndex = index;

			// Очистка предыдущих элементов
			foreach (Control c in this.Controls)
			{
				if (c is PictureBox || c is Label) this.Controls.Remove(c);
			}

			var exhibit = exhibits[index];



			// Панель для визуализации артефакта
			var artifactImage = new PictureBox
			{
				SizeMode = PictureBoxSizeMode.Zoom,
				Image = exhibit.Image,
				Size = new Size(400, 300),
				Location = new Point(200, 50),
				BorderStyle = BorderStyle.FixedSingle
			};
			this.Controls.Add(artifactImage);

			// Название и период
			var titleLabel = new Label
			{
				Text = $"{exhibit.Title}\n{exhibit.Author}",
				Font = new Font("Calibri", 14, FontStyle.Bold),
				AutoSize = true,
				Location = new Point(200, 370),
				ForeColor = Color.DarkSlateGray
			};
			this.Controls.Add(titleLabel);

			// Описание
			var descLabel = new Label
			{
				Text = exhibit.Description,
				Font = new Font("Calibri", 10),
				AutoSize = false,
				Size = new Size(400, 80),
				Location = new Point(200, 420)
			};
			this.Controls.Add(descLabel);

			// Факты
			var factsLabel = new Label
			{
				Text = exhibit.Facts.Replace("●", "•"),
				Font = new Font("Calibri", 9),
				AutoSize = false,
				Size = new Size(400, 100),
				Location = new Point(200, 500)
			};
			this.Controls.Add(factsLabel);
		}
		public class Exhibit
		{
			public string Title { get; set; }
			public string Author { get; set; }
			public string Description { get; set; }
			public Image Image { get; set; }
			public string Facts { get; set; }

			public Exhibit(string title, string author, string description, Image image, string facts)
			{
				Title = title;
				Author = author;
				Description = description;
				Image = image;
				Facts = facts;
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			InitializeExhibits();
			InitializeUI();
			ShowExhibit(currentExhibitIndex);
		}
	}
}