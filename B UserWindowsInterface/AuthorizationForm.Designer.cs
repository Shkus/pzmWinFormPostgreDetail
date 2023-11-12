namespace pzmWinFormPostgre
{
	partial class AuthorizationForm
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
			this.btnAuthorization = new System.Windows.Forms.Button();
			this.labelAuthorization = new System.Windows.Forms.Label();
			this.loginField = new System.Windows.Forms.TextBox();
			this.passwordField = new System.Windows.Forms.TextBox();
			this.labelLoginField = new System.Windows.Forms.Label();
			this.labelPasswordField = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnAuthorization
			// 
			this.btnAuthorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAuthorization.Location = new System.Drawing.Point(240, 299);
			this.btnAuthorization.Name = "btnAuthorization";
			this.btnAuthorization.Size = new System.Drawing.Size(270, 54);
			this.btnAuthorization.TabIndex = 0;
			this.btnAuthorization.Text = "Вход";
			this.btnAuthorization.UseVisualStyleBackColor = true;
			this.btnAuthorization.Click += new System.EventHandler(this.btnAuthorization_Click);
			// 
			// labelAuthorization
			// 
			this.labelAuthorization.AutoSize = true;
			this.labelAuthorization.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelAuthorization.Location = new System.Drawing.Point(292, 19);
			this.labelAuthorization.Name = "labelAuthorization";
			this.labelAuthorization.Size = new System.Drawing.Size(155, 25);
			this.labelAuthorization.TabIndex = 1;
			this.labelAuthorization.Text = "Авторизация";
			// 
			// loginField
			// 
			this.loginField.Location = new System.Drawing.Point(240, 140);
			this.loginField.Name = "loginField";
			this.loginField.Size = new System.Drawing.Size(270, 20);
			this.loginField.TabIndex = 2;
			// 
			// passwordField
			// 
			this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.passwordField.Location = new System.Drawing.Point(240, 218);
			this.passwordField.Name = "passwordField";
			this.passwordField.PasswordChar = '*';
			this.passwordField.Size = new System.Drawing.Size(270, 35);
			this.passwordField.TabIndex = 3;
			this.passwordField.UseSystemPasswordChar = true;
			// 
			// labelLoginField
			// 
			this.labelLoginField.AutoSize = true;
			this.labelLoginField.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelLoginField.Location = new System.Drawing.Point(37, 133);
			this.labelLoginField.Name = "labelLoginField";
			this.labelLoginField.Size = new System.Drawing.Size(173, 25);
			this.labelLoginField.TabIndex = 4;
			this.labelLoginField.Text = "Введите логин";
			// 
			// labelPasswordField
			// 
			this.labelPasswordField.AutoSize = true;
			this.labelPasswordField.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelPasswordField.Location = new System.Drawing.Point(37, 223);
			this.labelPasswordField.Name = "labelPasswordField";
			this.labelPasswordField.Size = new System.Drawing.Size(187, 25);
			this.labelPasswordField.TabIndex = 5;
			this.labelPasswordField.Text = "Введите пароль";
			// 
			// AuthorizationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.labelPasswordField);
			this.Controls.Add(this.labelLoginField);
			this.Controls.Add(this.passwordField);
			this.Controls.Add(this.loginField);
			this.Controls.Add(this.labelAuthorization);
			this.Controls.Add(this.btnAuthorization);
			this.Name = "AuthorizationForm";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAuthorization;
		private System.Windows.Forms.Label labelAuthorization;
		private System.Windows.Forms.TextBox loginField;
		private System.Windows.Forms.TextBox passwordField;
		private System.Windows.Forms.Label labelLoginField;
		private System.Windows.Forms.Label labelPasswordField;
	}
}

