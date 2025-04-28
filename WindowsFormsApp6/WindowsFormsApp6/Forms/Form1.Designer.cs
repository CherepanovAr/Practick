namespace WindowsFormsApp6
{
	partial class FormMain
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblBalance = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.listOrder = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblOrderId = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblTicker = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblTimeStamp = new System.Windows.Forms.Label();
			this.btnCreateOrder = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblSum = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnDeleteOrder = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblBalance);
			this.panel1.Controls.Add(this.lblName);
			this.panel1.Location = new System.Drawing.Point(495, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(225, 65);
			this.panel1.TabIndex = 0;
			// 
			// lblBalance
			// 
			this.lblBalance.AutoSize = true;
			this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblBalance.Location = new System.Drawing.Point(3, 42);
			this.lblBalance.Name = "lblBalance";
			this.lblBalance.Size = new System.Drawing.Size(51, 20);
			this.lblBalance.TabIndex = 1;
			this.lblBalance.Text = "label2";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblName.Location = new System.Drawing.Point(3, 9);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(51, 20);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "label1";
			// 
			// listOrder
			// 
			this.listOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listOrder.FormattingEnabled = true;
			this.listOrder.ItemHeight = 20;
			this.listOrder.Items.AddRange(new object[] {
            "BRPS 12"});
			this.listOrder.Location = new System.Drawing.Point(0, 0);
			this.listOrder.Name = "listOrder";
			this.listOrder.Size = new System.Drawing.Size(191, 184);
			this.listOrder.TabIndex = 2;
			this.listOrder.SelectedIndexChanged += new System.EventHandler(this.listOrder_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Номер ордера:";
			// 
			// lblOrderId
			// 
			this.lblOrderId.AutoSize = true;
			this.lblOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblOrderId.Location = new System.Drawing.Point(126, 16);
			this.lblOrderId.Name = "lblOrderId";
			this.lblOrderId.Size = new System.Drawing.Size(18, 20);
			this.lblOrderId.TabIndex = 3;
			this.lblOrderId.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(6, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Тикер:";
			// 
			// lblTicker
			// 
			this.lblTicker.AutoSize = true;
			this.lblTicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblTicker.Location = new System.Drawing.Point(59, 46);
			this.lblTicker.Name = "lblTicker";
			this.lblTicker.Size = new System.Drawing.Size(14, 20);
			this.lblTicker.TabIndex = 7;
			this.lblTicker.Text = "-";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(6, 107);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(139, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Время открытия:";
			// 
			// lblTimeStamp
			// 
			this.lblTimeStamp.AutoSize = true;
			this.lblTimeStamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblTimeStamp.Location = new System.Drawing.Point(138, 107);
			this.lblTimeStamp.Name = "lblTimeStamp";
			this.lblTimeStamp.Size = new System.Drawing.Size(14, 20);
			this.lblTimeStamp.TabIndex = 9;
			this.lblTimeStamp.Text = "-";
			// 
			// btnCreateOrder
			// 
			this.btnCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCreateOrder.Location = new System.Drawing.Point(12, 190);
			this.btnCreateOrder.Name = "btnCreateOrder";
			this.btnCreateOrder.Size = new System.Drawing.Size(150, 43);
			this.btnCreateOrder.TabIndex = 10;
			this.btnCreateOrder.Text = "Создать ордер";
			this.btnCreateOrder.UseVisualStyleBackColor = true;
			this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblSum);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lblOrderId);
			this.groupBox1.Controls.Add(this.lblTimeStamp);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.lblTicker);
			this.groupBox1.Location = new System.Drawing.Point(197, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(292, 142);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Информация об ордере";
			// 
			// lblSum
			// 
			this.lblSum.AutoSize = true;
			this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblSum.Location = new System.Drawing.Point(149, 76);
			this.lblSum.Name = "lblSum";
			this.lblSum.Size = new System.Drawing.Size(18, 20);
			this.lblSum.TabIndex = 11;
			this.lblSum.Text = "0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(6, 76);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(150, 20);
			this.label6.TabIndex = 10;
			this.label6.Text = "Общая стоимость:";
			// 
			// btnDeleteOrder
			// 
			this.btnDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDeleteOrder.Location = new System.Drawing.Point(12, 239);
			this.btnDeleteOrder.Name = "btnDeleteOrder";
			this.btnDeleteOrder.Size = new System.Drawing.Size(150, 43);
			this.btnDeleteOrder.TabIndex = 11;
			this.btnDeleteOrder.Text = "Удалить ордер";
			this.btnDeleteOrder.UseVisualStyleBackColor = true;
			this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(724, 287);
			this.Controls.Add(this.btnDeleteOrder);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCreateOrder);
			this.Controls.Add(this.listOrder);
			this.Controls.Add(this.panel1);
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "МТС";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblBalance;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.ListBox listOrder;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblOrderId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblTicker;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblTimeStamp;
		private System.Windows.Forms.Button btnCreateOrder;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblSum;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnDeleteOrder;
	}
}

