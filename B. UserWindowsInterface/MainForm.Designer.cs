namespace pzmWinFormPostgre
{
	partial class MainForm
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
			this.DGV_loadDetails = new System.Windows.Forms.DataGridView();
			this.DGV_loadItem = new System.Windows.Forms.DataGridView();
			this.btnAddDevices = new System.Windows.Forms.Button();
			this.btnEditDevices = new System.Windows.Forms.Button();
			this.btnDeleteDevices = new System.Windows.Forms.Button();
			this.btnDeleteItem = new System.Windows.Forms.Button();
			this.btnEditItem = new System.Windows.Forms.Button();
			this.btnAddItem = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DGV_loadDetails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DGV_loadItem)).BeginInit();
			this.SuspendLayout();
			// 
			// DGV_loadDetails
			// 
			this.DGV_loadDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DGV_loadDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_loadDetails.Location = new System.Drawing.Point(32, 49);
			this.DGV_loadDetails.Name = "DGV_loadDetails";
			this.DGV_loadDetails.Size = new System.Drawing.Size(844, 372);
			this.DGV_loadDetails.TabIndex = 4;
			// 
			// DGV_loadItem
			// 
			this.DGV_loadItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DGV_loadItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_loadItem.Location = new System.Drawing.Point(882, 49);
			this.DGV_loadItem.Name = "DGV_loadItem";
			this.DGV_loadItem.Size = new System.Drawing.Size(865, 372);
			this.DGV_loadItem.TabIndex = 5;
			// 
			// btnAddDevices
			// 
			this.btnAddDevices.Location = new System.Drawing.Point(32, 12);
			this.btnAddDevices.Name = "btnAddDevices";
			this.btnAddDevices.Size = new System.Drawing.Size(147, 23);
			this.btnAddDevices.TabIndex = 6;
			this.btnAddDevices.Text = "Добавить механизм";
			this.btnAddDevices.UseVisualStyleBackColor = true;
			// 
			// btnEditDevices
			// 
			this.btnEditDevices.Location = new System.Drawing.Point(185, 12);
			this.btnEditDevices.Name = "btnEditDevices";
			this.btnEditDevices.Size = new System.Drawing.Size(147, 23);
			this.btnEditDevices.TabIndex = 7;
			this.btnEditDevices.Text = "Редактировать механизм";
			this.btnEditDevices.UseVisualStyleBackColor = true;
			// 
			// btnDeleteDevices
			// 
			this.btnDeleteDevices.Location = new System.Drawing.Point(338, 12);
			this.btnDeleteDevices.Name = "btnDeleteDevices";
			this.btnDeleteDevices.Size = new System.Drawing.Size(147, 23);
			this.btnDeleteDevices.TabIndex = 8;
			this.btnDeleteDevices.Text = "Удалить механизм";
			this.btnDeleteDevices.UseVisualStyleBackColor = true;
			// 
			// btnDeleteItem
			// 
			this.btnDeleteItem.Location = new System.Drawing.Point(1188, 12);
			this.btnDeleteItem.Name = "btnDeleteItem";
			this.btnDeleteItem.Size = new System.Drawing.Size(147, 23);
			this.btnDeleteItem.TabIndex = 11;
			this.btnDeleteItem.Text = "Удалить деталь";
			this.btnDeleteItem.UseVisualStyleBackColor = true;
			// 
			// btnEditItem
			// 
			this.btnEditItem.Location = new System.Drawing.Point(1035, 12);
			this.btnEditItem.Name = "btnEditItem";
			this.btnEditItem.Size = new System.Drawing.Size(147, 23);
			this.btnEditItem.TabIndex = 10;
			this.btnEditItem.Text = "Редактировать деталь";
			this.btnEditItem.UseVisualStyleBackColor = true;
			// 
			// btnAddItem
			// 
			this.btnAddItem.Location = new System.Drawing.Point(882, 12);
			this.btnAddItem.Name = "btnAddItem";
			this.btnAddItem.Size = new System.Drawing.Size(147, 23);
			this.btnAddItem.TabIndex = 9;
			this.btnAddItem.Text = "Добавить деталь";
			this.btnAddItem.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1780, 450);
			this.Controls.Add(this.btnDeleteItem);
			this.Controls.Add(this.btnEditItem);
			this.Controls.Add(this.btnAddItem);
			this.Controls.Add(this.btnDeleteDevices);
			this.Controls.Add(this.btnEditDevices);
			this.Controls.Add(this.btnAddDevices);
			this.Controls.Add(this.DGV_loadItem);
			this.Controls.Add(this.DGV_loadDetails);
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.DGV_loadDetails)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DGV_loadItem)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView DGV_loadDetails;
		private System.Windows.Forms.DataGridView DGV_loadItem;
		private System.Windows.Forms.Button btnAddDevices;
		private System.Windows.Forms.Button btnEditDevices;
		private System.Windows.Forms.Button btnDeleteDevices;
		private System.Windows.Forms.Button btnDeleteItem;
		private System.Windows.Forms.Button btnEditItem;
		private System.Windows.Forms.Button btnAddItem;
	}
}