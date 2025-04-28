namespace WindowsFormsApp6.Forms
{
	partial class FormOrder
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.numQuantity = new System.Windows.Forms.NumericUpDown();
			this.comBoxTicker = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnBuy = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lblSum = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Тикер";
			// 
			// numQuantity
			// 
			this.numQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numQuantity.Location = new System.Drawing.Point(117, 50);
			this.numQuantity.Name = "numQuantity";
			this.numQuantity.Size = new System.Drawing.Size(52, 26);
			this.numQuantity.TabIndex = 1;
			this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
			// 
			// comBoxTicker
			// 
			this.comBoxTicker.FormattingEnabled = true;
			this.comBoxTicker.Items.AddRange(new object[] {
            "APPL",
            "MOEX",
            "BRPS"});
			this.comBoxTicker.Location = new System.Drawing.Point(117, 9);
			this.comBoxTicker.Name = "comBoxTicker";
			this.comBoxTicker.Size = new System.Drawing.Size(121, 21);
			this.comBoxTicker.TabIndex = 2;
			this.comBoxTicker.SelectedIndexChanged += new System.EventHandler(this.comBoxTicker_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Количество";
			// 
			// btnBuy
			// 
			this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnBuy.Location = new System.Drawing.Point(12, 151);
			this.btnBuy.Name = "btnBuy";
			this.btnBuy.Size = new System.Drawing.Size(83, 33);
			this.btnBuy.TabIndex = 4;
			this.btnBuy.Text = "Купить";
			this.btnBuy.UseVisualStyleBackColor = true;
			this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnBack.Location = new System.Drawing.Point(226, 151);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(83, 33);
			this.btnBack.TabIndex = 5;
			this.btnBack.Text = "Назад";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Итого:";
			// 
			// lblSum
			// 
			this.lblSum.AutoSize = true;
			this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblSum.Location = new System.Drawing.Point(76, 100);
			this.lblSum.Name = "lblSum";
			this.lblSum.Size = new System.Drawing.Size(18, 20);
			this.lblSum.TabIndex = 7;
			this.lblSum.Text = "0";
			// 
			// FormOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(321, 196);
			this.Controls.Add(this.lblSum);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnBuy);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comBoxTicker);
			this.Controls.Add(this.numQuantity);
			this.Controls.Add(this.label1);
			this.Name = "FormOrder";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Создание ордера";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOrder_FormClosed);
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numQuantity;
		private System.Windows.Forms.ComboBox comBoxTicker;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBuy;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblSum;
	}
}