namespace WindowsFormsApp6
{
	partial class LogForm
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
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblSwitchMode = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblTitle.Location = new System.Drawing.Point(185, 47);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(151, 28);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Вход";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(198, 222);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(124, 32);
			this.btnSubmit.TabIndex = 1;
			this.btnSubmit.Text = "Войти";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(209, 170);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(100, 20);
			this.txtPassword.TabIndex = 3;
			// 
			// txtUsername
			// 
			this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtUsername.Location = new System.Drawing.Point(209, 111);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(100, 23);
			this.txtUsername.TabIndex = 4;
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblUsername.Location = new System.Drawing.Point(185, 88);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(153, 20);
			this.lblUsername.TabIndex = 6;
			this.lblUsername.Text = "Имя пользователя";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblPassword.Location = new System.Drawing.Point(224, 147);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(67, 20);
			this.lblPassword.TabIndex = 7;
			this.lblPassword.Text = "Пароль";
			// 
			// lblSwitchMode
			// 
			this.lblSwitchMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblSwitchMode.Location = new System.Drawing.Point(134, 257);
			this.lblSwitchMode.Name = "lblSwitchMode";
			this.lblSwitchMode.Size = new System.Drawing.Size(265, 23);
			this.lblSwitchMode.TabIndex = 8;
			this.lblSwitchMode.TabStop = true;
			this.lblSwitchMode.Text = "Нет аккаунта? Зарегистрируйтесь";
			this.lblSwitchMode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblSwitchMode.Click += new System.EventHandler(this.lblSwitchMode_Click);
			// 
			// LogForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(519, 390);
			this.Controls.Add(this.lblSwitchMode);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.lblTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LogForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Авторизация";
			this.Load += new System.EventHandler(this.LogForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.LinkLabel lblSwitchMode;
	}
}